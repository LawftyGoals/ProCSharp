// See https://aka.ms/new-console-template for more information
using FunWithRecordStructs;

Console.WriteLine("***** Fun with Record Structs - Mutable 242 *****");

var rs = new PointRecordStruct(2, 4, 6);
Console.WriteLine(rs.ToString());

rs.X = 8;
Console.WriteLine(rs.ToString());

Console.WriteLine();

var rs2 = new PointRecordStandardStruct(2, 4, 6);
Console.WriteLine(rs2.ToString());
rs2.X = 8;
Console.WriteLine(rs2.ToString());

Console.WriteLine();

var rors = new PointRecordImmutablePositionStruct(2, 4, 6);
Console.WriteLine(rors.ToString());
//compliler error
// rors.X = 8;

Console.WriteLine();

Console.WriteLine("Deconstruction:");
var (x1, y1, z1) = rs;
Console.WriteLine($"X: {x1}, Y: {y1}, Z: {z1}");

var (x2, y2, z2) = rors;
Console.WriteLine($"X: {x2}, Y: {y2}, Z: {z2}");

rs.Deconstruct(out double x3, out double y3, out double z3);
Console.WriteLine($"X: {x3}, Y: {y3}, Z: {z3}");

rors.Deconstruct(out double x4, out double y4, out double z4);
Console.WriteLine($"X: {x4}, Y: {y4}, Z: {z4}");

Console.WriteLine();
