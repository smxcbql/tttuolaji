using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
   public class ExcelService
    {
        public bool CreateExcel(string filePath)
        {
            if(string.IsNullOrEmpty(filePath))
            {
                return false;
            }
            string sql = "select Id as 编号,Number as 工号,Name as 姓名,Inday as 入职时间,Nation as 民族,NativePlace as 籍贯 from Employee";
            DataTable dt = SqlHelper.GetTable(sql);
            IWorkbook workbook = new HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("员工列表");
            sheet.SetColumnWidth(0, 38 * 256);
            sheet.SetColumnWidth(3, 30 * 256);
            int rowCount = dt.Rows.Count;
            int columnCount = dt.Columns.Count;
            IRow headerRow = sheet.CreateRow(0);
            IFont headerFont = workbook.CreateFont();
            ICellStyle headerStyle = workbook.CreateCellStyle();
            headerFont.FontName = "宋体";
            headerStyle.SetFont(headerFont);
            headerStyle.Alignment = HorizontalAlignment.CENTER;
            for(int j=0;j<columnCount;j++)
            {
                ICell cell = headerRow.CreateCell(j);
                cell.CellStyle = headerStyle;
                cell.SetCellValue(dt.Columns[j].ColumnName);

            }
            for(int i=1;i<=rowCount;i++)
            {
                IRow row = sheet.CreateRow(i);
                for(int j =0;j<columnCount;j++)
                {
                    ICell cell = row.CreateCell(j);
                    if(j==3)
                    {
                        cell.SetCellValue((DateTime)dt.Rows[i - 1][j]);
                        ICellStyle cellstyle = workbook.CreateCellStyle();
                        cellstyle.DataFormat = workbook.CreateDataFormat().GetFormat("yyyy年m月d日 hh时mm分ss秒");
                        cell.CellStyle = cellstyle;
                    }
                    else
                    {
                        cell.SetCellValue(dt.Rows[i - 1][j].ToString());
                    }
                }
            }
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                workbook.Write(fs);
            }
            return true;
        }
    }
}
