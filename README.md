# PowershellHidden
Run powershell without a console window

Inspired by [stej{-at-}leporelo{-dot-}eu](http://www.leporelo.eu/blog.aspx?id=run-scheduled-tasks-with-winform-gui-in-powershell)

Just run `PowershellHidden Add-Type –a system.windows.forms; $form = new-object Windows.Forms.Form; [void]$form.showdialog()`
