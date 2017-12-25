using System;
using System.Linq.Expressions;

namespace Reflection
{
    public class BlockExpressionSample
    {
        public void Test()
        {
            BlockExpression blockExpr = Expression.Block(
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),
                    Expression.Constant("Hello ")
                ),
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }),
                    Expression.Constant("World!")
                )
            );
            Expression.Lambda<Action>(blockExpr).Compile()();
        }
    }
}
