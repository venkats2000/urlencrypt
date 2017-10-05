# urlencrypt
URL encryption project for Thrivepass

This implements two main functions one for encrypting a string (file location represented by an URL) and for decrypting the string and downloading
the file.

It also does a check for whether the time has expired for the download.  The time check is very simple and does not consider time zones etc., 
It is a simple date comparison.

You use the following link to test it. 
https://www.dropbox.com/s/u2e1ocu1zkwxj86/Unifyle%20exec%20summary.pdf?dl=1

Error handling is missing.  It should be done when we integrate with Thrivepass code.




