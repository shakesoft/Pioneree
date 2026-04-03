using System.Collections.Generic;

namespace PionereeDemo.DataExporting;

public interface IExcelColumnSelectionInput
{
    List<string> SelectedColumns { get; set; }
}

