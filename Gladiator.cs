using system;

    Random rnd = new Random;
    class Gladiator{

       int hp;
       int strg;
       string name;

       string[] names = {"archi", "achiles", "bob", "glave", "magics", "jett", "sova"};
    

        Public glad(int this.hp, int this.strg, string this.name)
        {
            this.hp = 100;
            this.strg = 20 + rnd.next(10);
            this.name = names[rnd.Next(names.Length)]; 
        }

        Public Hit(Gladiator target){
            Console.WriteLine($"")
        }

        Public TarDam(int dmg){
            hp -=dmg;
            Console.WriteLine($"{name} получил {dmg} урона")
        }   

        public string GetInfo(){
            return $"{name}[{strg}]({hp})";
        }

        
}