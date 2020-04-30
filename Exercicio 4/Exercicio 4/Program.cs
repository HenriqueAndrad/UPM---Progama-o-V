using System;

namespace Exercicio_4
{

    public static class FP
    {
        public static None None
            => None.Value;
        public static Option<T> Some<T>(T value)
            => new Some<T>(value);


    }

    public struct None
    {
        public static readonly None Value = new None();
    }

    public struct Some<T>
    {
        public T Value { get; }
        public Some(T value)
        {
            if (value == null) throw new ArgumentNullException();
            Value = value;
        }
    }

    public static class ChangeParse
    {

     public   static Option<int> Roberto(this String Nome)
        {
            bool sucess = int.TryParse(Nome, out int result);
            Option<int> Rivaldo = FP.None;
            if (sucess)
            {
                Rivaldo = result;
            }


            return Rivaldo;
        }
     public static Option<T> Reginaldo<T>(this String Nome) where T : struct
        {
            bool sucess = Enum.TryParse(Nome, out T result);
            Option<T> Rogerio = FP.None;
            if (sucess)
            {
                Rogerio = result;
            }


            return Rogerio;
        }

    }




    public struct Option<T>
    {
        readonly T Value;
        readonly bool isSome;

        private Option(T value)
        {
            Value = value;
            isSome = true;

        }

        public static implicit operator Option<T>(None _)
            => new Option<T>();

        public static implicit operator Option<T>(Some<T> some)
            => new Option<T>(some.Value);

        public static implicit operator Option<T>(T value)
            => value == null ? FP.None : FP.Some(value);

        public TResult Match<TResult>(Func<TResult> None, Func<T, TResult> Some)
            => isSome ? Some(Value) : None();

        public TResult Parse<TResult>(Func<TResult> None, Func<T, TResult> Some)
           => isSome ? Some(Value) : None();


        public override string ToString()
            => isSome ? $"{Value}" : "Option.None";






    }



    class Program
    {

        enum Days { Segunda, Terça, Quarta, Quinta, Sexta, Sábado, Domingo };

        static void Main(string[] args)
        {
            Option<string> optString = "Hello, World!";
            string matchString = optString.Match(
                None: () => "???",
                Some: (value) => value

                );
            Option<int> optInt = FP.None;
            int matchInt = optInt.Match(() => -1, (value) => value);

            Option<float> optFloat = FP.None;
            float matchFloat = optFloat.Match(() => float.NaN, (value) => value);


            Option<bool> optBool = FP.None;
            optBool = true;
            bool matchBool = optBool.Match(() => false, (value) => value);



            //Enum
            string Dia1 = "Segunda";
            string Dia2 = "Fevereiro";

            Option<Days> optDias1 = Dia1.Reginaldo<Days>();
            Option<Days> optDias2 = Dia2.Reginaldo<Days>();



            //Count
            string Value1 = "20";
            string Nome1 = "Adamastor";
            Option<int> optCount1 = Value1.Roberto();
            Option<int> optCount2 = Nome1.Roberto();

            //Name
            Option<string> optName = "Rodrigo";
            string matchName = optName.Match(
                None: () => "Hellow, World!",
                Some: (value) => "Hello, " + (value)

                );



            Console.WriteLine($"optString: {optString}, matchString: {matchString}");
            Console.WriteLine($"optInt: {optInt}, matchString: {matchInt}");
            Console.WriteLine($"optFloat: {optFloat}, matchFloat: {matchFloat}");
            Console.WriteLine($"optBool: {optBool}, matchBool: {matchBool}");

            Console.WriteLine($"optDias1: {optDias1}, optDias2: {optDias2}");

            Console.WriteLine($"optCount1: {optCount1}, optCount2: {optCount2}");


            Console.WriteLine($"optName: {optName}, matchName: {matchName}");
            Console.ReadKey();
        }
    }
}
