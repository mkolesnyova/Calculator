using System.Collections;


namespace CalculatorModel
{
    public sealed class SetCalculatorOperation : IEnumerable<KeyValuePair<string, IOperation>>
    {
        public Dictionary<string, IOperation> Operations { get; set; } = new();

        public IEnumerator<KeyValuePair<string, IOperation>> GetEnumerator()
        {
            return Operations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Operations.GetEnumerator();
        }

        public void Add(string op, IOperation Iop)
        {
            Operations.Add(op, Iop);
        }

        public void Add(string op, Func<double> zeroArgOp)
        {
            Operations.Add(op, new ZeroArgumentsOperation(zeroArgOp) );
        }

        public void Add(string op, Func<double, double> oneArgOp)
        {
            Operations.Add(op, new OneArgumentsOperation(oneArgOp));
        }

        public void Add(string op, Func<double, double, double> twoArgOp)
        {
            Operations.Add(op, new TwoArgumentsOperation(twoArgOp));
        }

        public bool ContainsOperation(string op) => Operations.ContainsKey(op);
    }
}
