# How to hide the column header of the DropDown Grid in WPF MultiColumnDropDownControl?

## About the sample

This sample illustrates how to hide the column header of the DropDown Grid in WPF MultiColumnDropDownControl.

[WPF MultiColumnDropDown](https://www.syncfusion.com/wpf-controls/multi-column-dropdown) (SfMultiColumnDropDownControl), allows you to hide the column header of the DataGrid displayed in the dropdown by setting the header row height of the dropdown grid to Zero.

```C#

this.multiColumnDropDown.Loaded += OnMultiColumnDropDown_Loaded;

private void OnMultiColumnDropDown_Loaded(object sender, RoutedEventArgs e)
{
    this.multiColumnDropDown.GetDropDownGrid().HeaderRowHeight = 0;
}

```

![SfMultiColumnDropDownControl hidden column header](SfMultiColumnDropDownControl_ColumnHeader.png)

Take a moment to peruse the [WPF MultiColumnDropDown - Getting Started](https://help.syncfusion.com/wpf/multi-column-dropdown/getting-started) documentation, where you can find about multicolumndropdown, with code examples.

## Requirements to run the demo

Visual Studio 2015 and above versions
