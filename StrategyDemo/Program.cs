MallardDuck mallard=new MallardDuck();

//mallard.Fly();

mallard.PerformFly();

//public interface Quackable
//{
//    void Quack();
//}

public interface QuackBehaviour
{
    void Quack();
}

public class QuackLikeADuck: QuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Quack quack");
    }
}

public class QuackWithAqueak : QuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Squeak squack");
    }
}

public class QuackMute : QuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("There is no sound");
    }
}

//public interface Flyable
//{
//    void Fly();
//}

public interface FlyBehaviour
{
    void Fly();
}

public class FlyWitYanjun : FlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("我自己写的东西");
    }
}

public class FlyWithWings : FlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("The bird flies");
    }
}

public class FlyCannotFly : FlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("The bird can't fly");
    }
}

public class FlyWithRocket : FlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("The duck somehow employs rocket propulsion");//鸭子以某种方式使用火箭推进
    }
}

public abstract class Duck//抽象类
{
    //通过对接口数据调取进行
    public FlyBehaviour FlyBehaviour { get; set; }
    public QuackBehaviour QuackBehaviour { get; set; }

    //public virtual void Quack()
    //{
    //    Console.WriteLine("Quack");
    //}

    //public void Swim()
    //{
    //    Console.WriteLine("The duck swims.");
    //}

    public void SetFlyBehaviour(FlyBehaviour fb)
    {
        FlyBehaviour = fb;
    }

    public void SetQuackBehaviour(QuackBehaviour qb)
    {
        QuackBehaviour = qb;
    }
    public void PerformFly()
    {
        FlyBehaviour.Fly();
    }

    public void PerformQuack()
    {
        QuackBehaviour.Quack();
    }

    //public virtual void Fly()
    //{
    //    Console.WriteLine("The duck flies.");
    //}

    public abstract void Display();//抽象方法

    public void Swim()
    {
        Console.WriteLine("All ducks can swim,including this one.");
    }
}

public class MallardDuck : Duck//,Flyable,Quackable
{
    public MallardDuck()
    {
        FlyBehaviour = new FlyWitYanjun();
        //FlyBehaviour = new FlyWithWings();
        QuackBehaviour = new QuackLikeADuck();
    }
    public override void Display()
    {
        Console.WriteLine("This duck looks like a mallard");
    }
}

//public class RedheadDuck : Duck//, Flyable, Quackable
//{
//    public override void Display()
//    {
//        Console.WriteLine("This duck has red fearhers on its head, I guess");//我猜这只鸭子头上有红色的恐吓器
//    }
//}

public class RubberDuck : Duck//, Quackable
{
    //public override void Quack()
    //{
    //    Console.WriteLine("This rubber duck squeaks");//这只橡皮鸭吱吱叫
    //}
    //public override void Fly()
    //{
    //    Console.WriteLine("The rubber duck cannot fly.");//橡皮鸭不会飞
    //}

    public RubberDuck()
    {
        FlyBehaviour = new FlyCannotFly();
        QuackBehaviour = new QuackWithAqueak();
    }
    public override void Display()
    {
        Console.WriteLine("It looks like a rubber duck.");//它看起来像一只橡皮鸭。
    }

    //public void Quack()//鸭子的叫声
    //{
    //    Console.WriteLine("The rubber duck squeaks.");//橡皮鸭吱吱叫。
    //}
}

public class Cyberduck : Duck//继承抽象类后需要重写继承方法
{
    public Cyberduck()
    {
        FlyBehaviour = new FlyWithRocket();
        QuackBehaviour = new QuackLikeADuck();
    }
    public override void Display()
    {
        Console.WriteLine("A duck that was nearly destroyed by criminals before its resurrection as the ultimate defender of justice. ");//一只几乎被罪犯摧毁的鸭子，在它作为正义的终极捍卫者复活之前。
    }
}
//create a new duck class called Cyberduck__创建一个名为Cyberduck的新鸭子类
//Cyberduck uses a rocket to fly, but quacks like a normal duck__Cyberduck用火箭飞行，但像普通鸭子一样嘎嘎叫