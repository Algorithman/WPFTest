
*WPF graphical issue test case*

Small program, one button, clicking on it only changes its text.
Window is intentionally small, it does not happen if the button in question is bigger.

Graphical glitch (as in GraphicalIssue.png) occurs after clicking the button or mouseover/out. (Probably only after mouseout)

I added my full dxdiag.txt for reference.

Drivers are all newest (just installed the 5950X yesterday), but i went the 'i dont have time to reinstall win10 and all my tools route'.

Also, another of my work projects has graphical issues. I have a animated color in the window and some usercontrols which bind to this color (as a warning signal).
There i don't have to mouseover at all, the controls which are bound to the animated color are just botched. Mouseover there restores them for 1 frame, then they go back to distorted.

VS 2019 version is 16.8.2
