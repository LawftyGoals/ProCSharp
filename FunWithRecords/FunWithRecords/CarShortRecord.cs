namespace FunWithRecords;


// internal record CarShortRecord(string Make, string Model, string Color);
internal record CarShortRecord(string Make, string Model, string Color) : CarRecord(Make, Model, Color);
