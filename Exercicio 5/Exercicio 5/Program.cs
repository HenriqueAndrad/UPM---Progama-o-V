using System;

namespace Exercicio_5
{

    /*
     Apply: (A<T -> R>, A<T>) -> A<R>
     Apply pega um applicative A<T -> R> que encapsula (wrap) uma função e um A<T> que encapsula um argumento e retorna um A<R> que encapsula o resultado de aplicar a função A<T -> R> no argumento A<T>.
      */

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


        public Option<TResult> Apply<TResult>(Option<Func<T, TResult>> func)
        {


            if (isSome && func.isSome)
            {
                return new Option<TResult>(func.Value(Value));
            }
            else
            {
                return new Option<TResult>();
            }
        }



    }



    class Program
    {

        public static Func<int, int> Roberto = Number => Number + 4;

        static void Main(string[] args)
        {
            Option<int> Num = 1;

            Option<Func<int, int>> Robervaldo = Roberto;


            Console.WriteLine("A soma é igual  = " + Num.Apply(Robervaldo));

            Console.ReadKey();
        }
    }
}
