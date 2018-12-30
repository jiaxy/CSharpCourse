using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{

    //定义一个委托，申明事件处理函数的格式 
    public delegate void ClickHandler(object sender, ClickEventArgs args);

    public class ClickEventArgs : EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class MyButton
    {
        //定义事件，相当于申明一个委托实例，初值为null
        public event ClickHandler OnClick;

        public void Click(int x, int y) {
            //触发Click事件
            ClickEventArgs args = new ClickEventArgs(){
                X = x,
                Y = y
            };
           
            OnClick(this, args);
        }
        
    }


    class Program {
    
        static void Main(string[] args) {
            MyButton btn = new MyButton();

            //为btn的OnClick事件添加两个处理方法
            btn.OnClick += new ClickHandler(Btn_OnClick); //添加一个委托实例
            btn.OnClick += new ClickHandler(Btn_OnClick2);//添加第二个委托实例

            btn.Click(100,200);//模拟点击按钮
        }

        static void Btn_OnClick(object sender, ClickEventArgs args) {
            Console.WriteLine($"Button被点击了,X={args.X},Y={args.Y}.");
        }

        static void Btn_OnClick2(object sender, ClickEventArgs args) {
            Console.WriteLine("Hello,World!");
        }
    }

  


}
