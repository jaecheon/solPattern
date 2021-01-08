using System;

namespace solPattern
{
    //UML 기초상식
    //https://hongjinhyeon.tistory.com/25
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //OptimizeSingleton ops1 = new OptimizeSingleton.;
            //OptimizeSingleton ops2 = new OptimizeSingleton.Instance();
            //ops1.Name = "This is new C# optimize snigleton class!!";
            //Console.WriteLine(ops2.Name);

            //EnemyGenerator[] enemyGenerators = new EnemyGenerator[2];
            //enemyGenerators[0] = new PatternAGenerator();
            //enemyGenerators[1] = new PatternBGenerator();

            //enemyGenerators[1].CreateEnemys();

            Proxy.Run();
        }
    }
}
