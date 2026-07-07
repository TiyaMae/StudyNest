using ClosedXML.Excel;
using StudyNestAPI.Models;

namespace StudyNestAPI.Services;

public class ExcelService
{
    private readonly string _filePath;

    public ExcelService()
    {
        _filePath = Path.Combine(AppContext.BaseDirectory, "Excel", "StudyNest.xlsx");
    }

    public List<StudySpace> GetStudySpaces()
    {
        var studySpaces = new List<StudySpace>();

        if (!File.Exists(_filePath))
            return studySpaces;

        using var workbook = new XLWorkbook(_filePath);

        var worksheet = workbook.Worksheet("StudySpaces");

        var rows = worksheet.RowsUsed().Skip(1);

        foreach (var row in rows)
        {
            studySpaces.Add(new StudySpace
            {
                ID = row.Cell(1).GetValue<int>(),
                Name = row.Cell(2).GetValue<string>(),
                Address = row.Cell(3).GetValue<string>(),
                Latitude = row.Cell(4).GetValue<double>(),
                Longitude = row.Cell(5).GetValue<double>(),
                PriceRange = row.Cell(6).GetValue<string>(),
                Wifi = row.Cell(7).GetValue<string>(),
                Outlets = row.Cell(8).GetValue<string>(),
                Hours = row.Cell(9).GetValue<string>(),
                NoiseLevel = row.Cell(10).GetValue<string>(),
                Open24Hours = row.Cell(11).GetValue<bool>(),
                Rating = row.Cell(12).GetValue<double>(),
                ImageUrl = row.Cell(13).GetValue<string>()
            });
        }

        return studySpaces;
    }
}