class BaldEagle : Animal {


    private string sound;
    public BaldEagle(string name, string sound) : base(name, sound) {}

    public virtual void MakeSound(){
        Console.WriteLine($"{this.name} says: {this.sound}");
    }
}