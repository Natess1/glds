using system;

    Random rnd = new Random;
    class Player{
        Public Player(){
       int glory = 0;
       int money = 50;
        }

        Public hill(Gladiator){
            if(money > 10){
                if(glad.hp < 91){
                glad.hp += 10;
                money -= 10;
                }
                else{
                    Console.WriteLine("У этого бойца здоровье, не позволяющее его увеличить.");
                }
            }
            else{
                Console.WriteLine("У вас недостаточно средств!");
            }
        }

        object[] glads = new object[10];

        Public BuyGlad(){
            if( money > 50){
                glads.Add(glad);
            } 
            else{
                Console.WriteLine("У вас недостаточно средств");

            }
        }
    





    }

