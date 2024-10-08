﻿namespace CustomInterfaces;
internal interface IRegularPointy : IPointy {

    int SideLength { get; set; }
    int NumberOfSides { get; set; }
    int Perimeter => SideLength * NumberOfSides;
}
