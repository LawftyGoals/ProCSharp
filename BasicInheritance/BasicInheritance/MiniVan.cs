namespace BasicInheritance;

// sealed class prevents inheritance
internal sealed class MiniVan : Car //, OtherCar - Multiple Inheritance doesnt work
 {





    public void TestMethod() {
        //works because parent property is public
        Speed = 10;

        //Wont work will cause error because private:
        //_currSpeed = 10;

    }
}
