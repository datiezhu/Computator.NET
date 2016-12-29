﻿using System.Diagnostics;
using System.Windows.Data;
using System.Windows.Forms.Integration;
using System.Windows.Media.Media3D;
using Computator.NET.Core.Evaluation;
using Computator.NET.Core.Properties;
using Computator.NET.DataTypes;

namespace Computator.NET.Evaluation
{
    public interface IScriptEvaluator
    {
        ScriptFunction Evaluate(string input, string customFunctionsCode);
    }

    public class ScriptEvaluator : ExpressionsEvaluator, IScriptEvaluator
    {
        private readonly string _additionalObjectsCodeCopy;

        public ScriptEvaluator()
        {
            FunctionType = FunctionType.Scripting;
            AdditionalUsings = @"
            //using System.Collections.Generic;
            //using System.Windows.Forms.Integration;
            //using System.Linq;
            //using Computator.NET.Charting;
            //using Complex = System.Numerics.Complex;
            //using DenseVector = MathNet.Numerics.LinearAlgebra.Complex.DenseVector;
            //using MathNet.Numerics.LinearAlgebra;
            //using MathNet.Numerics.LinearAlgebra.Double;
            //using Meta.Numerics; 
            //using System.IO;
            //using System.Windows.Forms;
            //using System.Windows.Media;
            //using System.Windows.Media.Media3D;
            //using Computator.NET.Charting.Chart3D;
            //using Computator.NET.Charting.ComplexCharting;
            //using Computator.NET.Charting.RealCharting;
            //using Computator.NET.DataTypes;
            //using Computator.NET.DataTypes.SettingsTypes;
            //using Meta.Numerics.Matrices;
            ";

            NativeCompiler.AddDll(GlobalConfig.FullPath("Computator.NET.Charting.dll"));
            NativeCompiler.AddDll(GlobalConfig.FullPath("Computator.NET.DataTypes.dll"));
            /////////////////////////
            NativeCompiler.AddDll("System.Drawing.dll");
            NativeCompiler.AddDll("System.Windows.Forms.DataVisualization.dll");
            NativeCompiler.AddDll("System.Windows.Forms.dll");
            NativeCompiler.AddDll("System.Xaml.dll");
            //NativeCompiler.AddDll("Microsoft.CSharp.dll");


            NativeCompiler.AddDll(typeof(AmbientLight).Assembly.Location);
            //"PresentationCore.dll");
            NativeCompiler.AddDll(typeof(XmlDataProvider).Assembly.Location);
            //"PresentationFramework.dll");
            NativeCompiler.AddDll(typeof(PresentationTraceSources).Assembly.Location);
            //"WindowsBase.dll");
            NativeCompiler.AddDll(typeof(ElementHost).Assembly.Location);
            //"WindowsFormsIntegration.dll");

            NativeCompiler.IsScripting = true;

            _additionalObjectsCodeCopy = AdditionalObjectsCode = NumericalExtensions.ToCode + ScriptingExtensionObjects.ToCode;
            Logger.ClassName = GetType().FullName;
        }

        public ScriptFunction Evaluate(string input, string customFunctionsCode)
        {
            MainTslCode = input;
            CustomFunctionsTslCode =
                !string.IsNullOrEmpty(customFunctionsCode) && !string.IsNullOrWhiteSpace(customFunctionsCode)
                    ? customFunctionsCode
                    : "";
            ;


            AdditionalObjectsCode = _additionalObjectsCodeCopy.Replace(
                @"Properties.Settings.Default.NumericalOutputNotation",
                "Computator.NET.DataTypes.SettingsTypes.NumericalOutputNotationType." +
                Settings.Default.NumericalOutputNotation);
            //DataTypes.SettingsTypes.NumericalOutputNotationType.MathematicalNotation

            var function = Compile();
            return new ScriptFunction(function) {TslCode = MainTslCode, CsCode = MainCSharpCode};
        }
    }
}