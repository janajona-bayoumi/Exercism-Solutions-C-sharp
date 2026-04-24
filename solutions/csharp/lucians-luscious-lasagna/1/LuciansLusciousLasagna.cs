class Lasagna
{
    public int ExpectedMinutesInOven() {
        return 40;
    }
    public int RemainingMinutesInOven(int mins){
        return 40 - mins;
    }
    public int PreparationTimeInMinutes(int layers){
        return layers * 2;
    }
    public int ElapsedTimeInMinutes(int layers, int minutes){
        return (layers * 2) + minutes;
    }
}
