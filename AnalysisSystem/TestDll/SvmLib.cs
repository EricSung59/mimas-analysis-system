using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TestDll
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct svm_parameter
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
    public unsafe struct svm_node
    {
        int index;
        double value;

        public svm_node(int pIndex, double pValue)
        {
            index = pIndex;
            value = pValue;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct svm_model
    {
        svm_parameter parameter;	/* parameter */
        int nr_class;		/* number of classes, = 2 in regression/one class svm */
        int l;				/* total #SV */
        svm_node** SV;		/* SVs (SV[l]) */
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

    class SvmLib
    {
        //------------------------ PRIVATE UNMANAGED FUNCTION ----------------//

        [DllImport("SvmLib.dll", EntryPoint = "add", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Unmanaged_add(int a, int b);

        [DllImport("SvmLib.dll", EntryPoint = "svm_load_model", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern IntPtr Unmanaged_svm_load_model(String model_file_name);

        [DllImport("SvmLib.dll", EntryPoint = "svm_predict", CallingConvention = CallingConvention.Cdecl)]
        private static extern double Unmanaged_svm_predict(ref svm_model model, svm_node[] node);

        //------------------------ PUBLIC METHODS ----------------------------//

        public static svm_model LoadModel(string modelFilePath)
        {
            IntPtr model_p = Unmanaged_svm_load_model(modelFilePath);
            return (svm_model)Marshal.PtrToStructure(model_p, typeof(svm_model));
        }

        public static double Predict(svm_model model, svm_node[] node) 
        {
            return Unmanaged_svm_predict(ref model, node);
        }
    }
}


//[DllImport("SvmLib.dll", EntryPoint = "svm_load_model", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
//[return: MarshalAs(UnmanagedType.LPStruct)]
//private static extern SvmLib.svm_model Unmanaged_svm_load_model(string model_file_name)