/*
Create a tableLayout, add one row and one column then set the top and bottom left and right to 50% and the middle two to AutoSize.
http://stackoverflow.com/questions/5110686/c-sharp-winforms-center-content
*/

tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));