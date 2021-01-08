using System;
using System.Collections.Generic;
using System.Text;

namespace solPattern
{
    //https://codepump.tistory.com/26?category=672020
    public enum EnemyType
    {
        Zombie,
        Slime
    }

    public abstract class Enemy
    {
        protected EnemyType enemyType;
        protected string name;
        protected int hp;
        protected int exp;

        protected void Attack() { }
    }

    public class Zombie: Enemy
    {
        public Zombie()
        {
            enemyType = EnemyType.Zombie;
            name = "Zombie";
            hp = 100;
            exp = 50;

            Console.WriteLine("{0} : 출현!!!", this.name);
        }
    }

    public class Slime : Enemy
    {
        public Slime()
        {
            enemyType = EnemyType.Slime;
            name = "Slime";
            hp = 200;
            exp = 15;

            Console.WriteLine("{0} : 출현!!", this.name);
        }
    }

    public abstract class EnemyGenerator
    {
        private List<Enemy> _enemy = new List<Enemy>();

        public EnemyGenerator()
        {

        }

        public List<Enemy> Enemys
        {
            get { return _enemy; }
        }

        public abstract void CreateEnemys();
    }

    public class PatternAGenerator : EnemyGenerator
    {
        public override void CreateEnemys()
        {
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
        }
    }

    public class PatternBGenerator: EnemyGenerator
    {
        public override void CreateEnemys()
        {
            Enemys.Add(new Slime());
            Enemys.Add(new Slime());
            Enemys.Add(new Slime());
            Enemys.Add(new Slime());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
        }
    }
}
