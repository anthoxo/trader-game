using System;

namespace trader_game
{
    class game{
        public static int purchase_init = -10;
        public static int sale_init = 11;

        int price_a;
        int price_b;
        int price_c;
        int price_gold;
        int price_silver;
        int price_bronze;
        public game(){
            this.price_a = 40;
            this.price_b = 30;
            this.price_c = 20;
            this.price_gold = 120;
            this.price_silver = 105;
            this.price_bronze = 90;
        }
        /*TODO
        update_value
        */
        public void update_value(int a, int b, int c,
        int gold, int silver, int bronze){
            this.price_a += game.purchase_init + a;
            this.price_b += game.purchase_init + b;
            this.price_c += game.purchase_init + c;
            this.price_gold += game.sale_init - 2*gold;
            this.price_silver += game.sale_init - 2*silver;
            this.price_bronze += game.sale_init - 2*bronze;
        }

    }

    class main{
        static void Main(string[] args){
            game o = new game();
            System.Console.WriteLine(game.purchase_variations);
        }
    }
}
