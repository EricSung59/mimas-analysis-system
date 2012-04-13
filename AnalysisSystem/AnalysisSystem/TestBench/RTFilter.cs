using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestBench
{
    class RTFilter{
	    double[]	_pPreX;			// Values of X of previous filtering
	    double[]	_pPreY;			// Values of Y of previous filtering
	    double[]	_pB;			// Filter coeff for numerator
	    double[]	_pA;			// Filter coeff for denumerator
	    int		    _nOrder;	    // Order of the filter    
        bool        _isInitialConditionReady = false;
    
	    // Constructor with filter coeff and order explicitly passed in.
	    public RTFilter(int nOrder, double[] pB, double[] pA)
        {
            _nOrder = nOrder;
	        
	        _pB = new double[_nOrder+1];
	        _pA = new double[_nOrder+1];

	        for ( int i = 0 ; i<=_nOrder ; i++ ){
		        _pB[i] = pB[i];
		        _pA[i] = pA[i];
	        }

	        _pPreX = new double[_nOrder];
	        _pPreY = new double[_nOrder];
        }
	    ~RTFilter()
        {
        }

	    // Sets the initial condition.
        public void ResetInitialValue(double valX, double valY)
        {            
            for ( int i=0 ; i<_nOrder ; i++ ){
	            _pPreX[i] = valX;
	            _pPreY[i] = valY;
            }        
        }
        public void ScaleInitialValue(double facX, double facY)
        {
            for ( int i=0 ; i<_nOrder ; i++ ){
		        _pPreX[i] *= facX;
		        _pPreY[i] *= facY;
	        }
        }

        public void SetInitialValue(double[] pPreX, double[] pPreY)
        {            
	        for ( int i=0 ; i<_nOrder ; i++ ){
		        _pPreX[i] = pPreX[i];
		        _pPreY[i] = pPreY[i];
	        }
        }
	    // Actual filtering.
        public double[] Filter(double[] pX)
        {            
            int np = pX.Length;
            double[] pY = new double[np];
            int order = GetOrder();
            

	        if ( !_isInitialConditionReady  ){		        
                ResetInitialValue(pX[0], pX[0]);	
                _isInitialConditionReady = true;
	        }

	        for ( int i=0 ; i<np ; i++) {
		        pY[i] = 0;
		        for ( int j=0 ; j<=order; j++) {
			        pY[i]+= _pB[j] * ( (i-j)>=0 ? pX[i-j] : _pPreX[order+(i-j)] );
		        }
		        for ( int j=1; j<=order; j++ ) {
			        pY[i]-= _pA[j] * ( (i-j)>=0 ? pY[i-j] : _pPreY[order+(i-j)] );
		        }
	        }

	        for ( int i=0 ; i<order ; i++ ) {
		        _pPreX[i] = (np-order+i)>=0 ? pX[np-order+i] : _pPreX[order+(np-order+i)];
		        _pPreY[i] = (np-order+i)>=0 ? pY[np-order+i] : _pPreY[order+(np-order+i)];
	        }

            return pY;
        }

	    // Get the order of the filter.
        public int GetOrder() { return _nOrder; }

	    // Get the numerator coefficients
        public double[] GetNumCoef()
        {            
            return (double[])_pB.Clone();
        }

	    // Get the denominator coefficients
        public double[] GetDenCoef()
        {
            return (double[])_pA.Clone();
        }
    }
}
