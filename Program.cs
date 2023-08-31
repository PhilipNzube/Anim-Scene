using System;
using SplashKitSDK;

public class Program{
    public static void Main(){
        //Window object and background bitmap creation
        Window fightWindow = new Window("AnimationScene", 640, 480);
        Bitmap background = new Bitmap("Arena", "BG.png");
        fightWindow.DrawBitmap(background,0,0);

        //Animation Bitmap object creation
        Bitmap Anim1 = new Bitmap("Animation1", "Anim1.png");
        Bitmap Anim2 = new Bitmap("Animation2", "Anim2.png");
        Bitmap Anim3 = new Bitmap("Animation3", "Anim3.png");
        Bitmap Anim4 = new Bitmap("Animation4", "Anim4.png");
        Bitmap Anim5 = new Bitmap("Animation5", "Anim5.png");
        Bitmap Anim6 = new Bitmap("Animation6", "Anim6.png");
        Bitmap Anim7 = new Bitmap("Animation7", "Anim7.png");

        //Soundeffect object creation
        SoundEffect SE = new SoundEffect("SE", "SoundEffect.mp3");

        SE.Play();
        SplashKit.Delay(300);
        
        //Action Sequence 
        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim1, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200); 

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim2, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim3, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim4, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim4, 150, 75);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim4, 150, 50);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim5, 150, 75);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim5, 150, 100);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim6, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim7, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Anim1, 150, 150);
        fightWindow.DrawText("FIGHT!!", Color.Red, "StencilStd.otf", 200, 200, fightWindow.Height / 2);
        fightWindow.Refresh();
        SplashKit.Delay(10000);
    }
}
