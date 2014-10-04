CustomFontDialog is an alternative to the standard .Net [FontDialog](http://msdn.microsoft.com/en-us/library/system.windows.forms.fontdialog.aspx). 

Key advantage of CustomFontDialog is the full control over look and feel as it is open source.

CustomFontDialog avoids 'This is not a True Type Font' exception that affects the standard dialog in some cases. Most probably the exception happens when some installed fonts have invalid meta information. This exception cannot be caught using try/catch block because the exception is thrown from the code outside .Net framework. The exact exception message is 'Only TrueType fonts are supported. This is not a TrueType font.'. CustomFontDialog gets around this problem by loading only True Type fonts. More details about the problem with standard dialog can be found [here](http://c-madeeasy.blogspot.ae/2011/11/unsolved-this-is-not-true-type-font.html) and [here](http://stackoverflow.com/questions/6302454/c-sharp-setting-fontdialog-to-only-display-truetype-fonts).

Moreover, CustomFontDialog incorporates few additional features like easy access to recently used fonts.

####Download
Binary and source files can be downloaded as a zip file from [here](https://sourceforge.net/projects/customfontdialog/files/latest/download).

####Usage

Following C# code snippet demonstrates how to instantiate and display Custom FontDialog.

```csharp
 CustomFontDialog.FontDialog fontDialog = new CustomFontDialog.FontDialog();
 fontDialog.Font = new Font(FontFamily.GenericSansSerif, 10); // sets the default font

 if (fontDialog.ShowDialog() == DialogResult.OK)
 {
    // Font is selected. Get the selected font using 'fontDialog.Font' 
 }
 else
 {
    // FontDialog is canceled by the user, your code here to handle cancel action
 }
 ```


<br>

For the CustomFontDialog to retain the recently selected fonts at the top of the list, the dialog should be instantiated only once and _ShowDialog_ function should be called on the same object whenever the dialog needs to be displayed.

To programmatically add Fonts to be 'Recently Used Fonts' section, call _AddFontToRecentList_ method.

####Limitations
As compared to the standard FontDialog, CustomFontDialog doesn't support changing text color. 

####Updates

######Version 0.2.0
1. In Font List, arrow keys can be used to move between 'Recently Used' and 'All Fonts' sections.
2. When user starts typing in Font List, the focus shifts to the filter Text box automatically.
3. Whenever CustomFontDialog is displayed, the focus is on Font List by default.

####Screen Shot
![Image of CustomFontDialog](https://a.fsdn.com/con/app/proj/customfontdialog/screenshots/CustomFontDialog.png)
