import java.util.ArrayList;

import static java.lang.System.exit;

public class BingoBag extends BingoBall
{
    ArrayList<BingoBall> myBag;
    public BingoBag()
    {
        myBag = new ArrayList<BingoBall>();
        for (int i = 0; i < 75; i++)
        {
            try
            {
                if ( i < 15)
                {
                    myBag.add(new BingoBall('B', i + 1));
                    myBag.get(i).setMarked(false);
                }
                else if ( i < 30)
                {
                    myBag.add(new BingoBall('I', i + 1));
                    myBag.get(i).setMarked(false);
                }
                else if ( i < 45)
                {
                    myBag.add(new BingoBall('N', i + 1));
                    myBag.get(i).setMarked(false);
                }
                else if ( i < 60)
                {
                    myBag.add(new BingoBall('G', i + 1));
                    myBag.get(i).setMarked(false);
                }
                else if ( i < 75)
                {
                    myBag.add(new BingoBall('O', i + 1));
                    myBag.get(i).setMarked(false);
                }
                else
                {
                    System.out.println("you messed up your vertices");
                }
            }
            catch(InvalidBingoSymbolException e)
            {
                e.printStackTrace();
                exit(1);
            }
            catch (InvalidBingoValueException ex)
            {
                ex.printStackTrace();
                exit(1);
            }
        }
    }

    public BingoBall draw()
    {
        Random rand = new Random();

    }
    public static void main(String [] args)
    {

    }
}

