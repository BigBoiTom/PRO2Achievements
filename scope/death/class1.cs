using System;

namespace scope.death{}

public class Class1{

    public int nummerA = 20;
    protected int nummerB = 40;
    private int nummerC = 80;
    
}

public class Class2 : Class1{

    public static int getalA = 10;
    

    public void Function(){

        Class2.getalA = 5;


    }

    protected void Function2(){

        nummerB = 30;
        this.nummerB += 4;

    }


    private void Function3(){

        int getalB = 321334;


    }



}