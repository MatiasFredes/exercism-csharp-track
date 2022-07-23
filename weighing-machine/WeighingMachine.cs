using System;

class WeighingMachine
{
    private double weight;

    // TODO: define the 'Precision' property

    // TODO: define the 'Weight' property

    // TODO: define the 'DisplayWeight' property

    // TODO: define the 'TareAdjustment' property
    public WeighingMachine(int precision)
    {
        this.Precision = precision;
        TareAdjustment = 5;
    }

    public int Precision { get; private set; }
    public double TareAdjustment { get; set; }
    public string DisplayWeight 
    {
        get
        {
            string output = string.Format("{0:F3}", Weight - TareAdjustment);
            return $"{output} kg";
        }
    }
    public double Weight 
    {
        get
        {
            return weight;
        }
        set { 
            if(value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                weight = value;
            }
        } 
    }
}
