using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace AnalysisSystem
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SvmParameter
    {
        int svm_type;
        int kernel_type;
        int degree;	/* for poly */
        double gamma;	/* for poly/rbf/sigmoid */
        double coef0;	/* for poly/sigmoid */

        /* these are for training only */
        double cache_size; /* in MB */
        double eps;	/* stopping criteria */
        double C;	/* for C_SVC, EPSILON_SVR and NU_SVR */
        int nr_weight;		/* for C_SVC */
        int* weight_label;	/* for C_SVC */
        double* weight;		/* for C_SVC */
        double nu;	/* for NU_SVC, ONE_CLASS, and NU_SVR */
        double p;	/* for EPSILON_SVR */
        int shrinking;	/* use the shrinking heuristics */
        int probability; /* do probability estimates */
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SvmNode
    {
        int index;
        double value;

        public SvmNode(int pIndex, double pValue)
        {
            index = pIndex;
            value = pValue;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SvmModel
    {
        SvmParameter parameter;	/* parameter */
        int nr_class;		/* number of classes, = 2 in regression/one class svm */
        int l;				/* total #SV */
        SvmNode** SV;		/* SVs (SV[l]) */
        double** sv_coef;	/* coefficients for SVs in decision functions (sv_coef[k-1][l]) */
        double* rho;		/* constants in decision functions (rho[k*(k-1)/2]) */
        double* probA;		/* pairwise probability information */
        double* probB;

        /* for classification only */

        int* label;		/* label of each class (label[k]) */
        int* nSV;		/* number of SVs for each class (nSV[k]) */
        /* nSV[0] + nSV[1] + ... + nSV[k-1] = l */
        /* XXX */
        int free_sv;		/* 1 if svm_model is created by svm_load_model*/
        /* 0 if svm_model is created by svm_train */
    }

    public class SvmLibWrapper
    {
        //------------------------ PRIVATE UNMANAGED FUNCTION ----------------//

        [DllImport("SvmLib.dll", EntryPoint = "svm_load_model", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern IntPtr Unmanaged_svm_load_model(String model_file_name);

        [DllImport("SvmLib.dll", EntryPoint = "svm_predict", CallingConvention = CallingConvention.Cdecl)]
        private static extern double Unmanaged_svm_predict(ref SvmModel model, SvmNode[] node);

        //------------------------ PUBLIC METHODS ----------------------------//

        public static SvmModel LoadModel(string modelFilePath)
        {
            IntPtr model_p = Unmanaged_svm_load_model(modelFilePath);
            return (SvmModel)Marshal.PtrToStructure(model_p, typeof(SvmModel));
        }

        public static double Predict(SvmModel model, SvmNode[] node)
        {
            return Unmanaged_svm_predict(ref model, node);
        }
    }
}
