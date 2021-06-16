import java.util.*;

public class AnimalRunner
{
    public static void main(String[] args)
    {
        ArrayList<Speakable> dogcatList = new ArrayList<>();
        dogcatList.add(new Dog("Fred"));
        dogcatList.add(new Cat("Wanda"));
        System.out.println(dogcatList.toString());

        for (Speakable obj : dogcatList)
        {
            obj.speak();
        }
    }
}

//[Dog:  Fred, Cat:  Wanda]
//        Woof! Woof!
//        Meow! Meow!
