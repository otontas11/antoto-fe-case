// Constants/BillCardConstants.cs
public static class BillCardConstants
{
    public static readonly List<BillCardModel> BillCardData = new()
    {
        new BillCardModel
        {
            TransactionDate = "2024-12-01",
            PlateNo = "34 AB 123",
            TransactionNumber = 1001,
            TransactionStatus = "Tamamlandı",
            VehicleID = "SN10052208148547",
            TotalKW = 45,
            TotalAmount = 150,
            PaymentCardID = "**** 5001",
            PaymentCardName = "Visa"
        },
        new BillCardModel
        {
            TransactionDate = "2024-12-02",
            PlateNo = "02 XY 456",
            TransactionNumber = 1002,
            TransactionStatus = "İptal",
            VehicleID = "SN980052208148543",
            TotalKW = 60,
            TotalAmount = 200,
            PaymentCardID = "**** 3456",
            PaymentCardName = "Master"
        },
        new BillCardModel
        {
            TransactionDate = "2021-06-11",
            PlateNo = "07 TOGG 890",
            TransactionNumber = 1012,
            TransactionStatus = "Tamamlandı",
            VehicleID = "SN522036788148599",
            TotalKW = 120,
            TotalAmount = 600,
            PaymentCardID = "**** 9000",
            PaymentCardName = "Visa"
        }
    };
}
