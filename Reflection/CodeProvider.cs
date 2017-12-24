﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class CodeProvider
    {
        public void Generate()
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit();
            CodeNamespace myNamespace = new CodeNamespace("MyNamespace");
            myNamespace.Imports.Add(new CodeNamespaceImport("System"));
            CodeTypeDeclaration myClass = new CodeTypeDeclaration("MyClass");
            CodeEntryPointMethod start = new CodeEntryPointMethod();
            CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression(
            new CodeTypeReferenceExpression("Console"),
            "WriteLine", new CodePrimitiveExpression("Hello World!"));
            compileUnit.Namespaces.Add(myNamespace);
            myNamespace.Types.Add(myClass);
            myClass.Members.Add(start);
            start.Statements.Add(cs1);
        }
    }
}
