
namespace ObjectOverrides;
internal class Quokka {
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Age { get; set; }

    public Quokka(string fN, string lN, int pA) {
        FirstName = fN;
        LastName = lN;
        Age = pA;
    }
    public Quokka() {

    }

    /*public override bool Equals(object obj) {
        if (!(obj is Quokka temp)) {
            return false;
        }
        if (temp.FirstName == this.FirstName && temp.LastName == this.LastName && temp.Age == this.Age) {
            return true;
        }
        return false;
    }*/

    public override bool Equals(object? obj) => obj?.ToString() == ToString();

    public override string ToString() => $"First Name: {FirstName}, Last Name: {LastName}, Age: {Age}";

    public override int GetHashCode() => ToString().GetHashCode();


}
