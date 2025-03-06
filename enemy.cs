using System;

    class Enemy{

        int hp;
        int strg;
        string name;

        string[] names = {"Нечисть", "Гладиатор"}


        Public EsEnemy(){
            hp = 50;
            strg = 10 + rnd.Next(5);
            name = "Нечисть";
        }
        Public HrdEnemy(){
            hp = 100;
            strg = 20 + rnd.Next(10);
            name = "Гладиатор";
        }

        Public Hit(Enemy target){
            Console.WriteLine($"{name} ударил {target.GetInfo()} с силой {strg}");
            TrgDam(strg);
        }

        Public TrgDam(int dmg){
            hp -= dmg;
            Console.WriteLine($"{name} получил {dmg} урона!");
        }


        Public Info(){
            Console.WriteLine($"Имя:{name}\nСила:[{strg}]\nЗдоровье({hp})")
        }

        Public void GetInfo(){
            return$"{name}[{strg}]({hp})";
        }

        

    }