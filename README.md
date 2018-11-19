# Ghostmouse-Looper
Created 11/19/2018
Author: Christian Loveridge
Contact: christian.loveridge@gmail.com

A simple utility with GUI for looping Ghostmouse recordings. Give it a number of loops, the number of seconds between each loop, and the
key to press at the start of each iteration (Ghostmouse can be set to activate upon the press of a specific key, such as  F6).

Ghostmouse is not required, but it's free and runs with no istallation. Basically, any keylogger which can loop at the press of a key
will work. There is a link to the ghostmouse site on the form.

CURRENT KNOWN ISSUES (11/19/2018):
- Program continues to run after closing, if user presses "Exit" instead of "Stop".
- Program doesn't actually activate GhostMouse, presumably due to bad formatting in the SendKeys.Send() method. This may have been fixed with the last commit, but haven't tested yet.
- Default label text for running stats isn't blank
- Running stats need to reset upon completion.
- Certain form elements should be disabled or greyed out while the main loop is running, to draw focus to the running stats.
