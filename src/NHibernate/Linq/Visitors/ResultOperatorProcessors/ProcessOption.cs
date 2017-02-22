using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.Linq.Visitors.ResultOperatorProcessors
{
    internal class ProcessOption : IResultOperatorProcessor<OptionResultOperator>
    {
        public void Process(OptionResultOperator resultOperator, QueryModelVisitor queryModelVisitor, IntermediateHqlTree tree)
        {
            tree.AddAdditionalCriteria((q, p) => q.SetOption((string)resultOperator.Option.Value));
        }
    }
}