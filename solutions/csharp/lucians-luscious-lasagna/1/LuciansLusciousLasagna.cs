public class Lasagna
{
    int ExpectedMinutesToCook = 40;
    int EachLayerTime = 2;
    public int ExpectedMinutesInOven () {
        return ExpectedMinutesToCook;
    } 

    public int RemainingMinutesInOven (int a){
        return ExpectedMinutesToCook - a;
    }
    
    public int PreparationTimeInMinutes (int a){
        return EachLayerTime * a;
    }

    public int ElapsedTimeInMinutes (int a, int b){
        int PrepTime = EachLayerTime * a;
        return PrepTime + b;
    }
}