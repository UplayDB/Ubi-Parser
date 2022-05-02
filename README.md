# Ubi-Parser
A Parser Libary (or add-on) to Read from Ubisoft Connect Cache files
It can parse the files from Stream or from the disk.

*It contains ALL the C# Protobuf files from upc (uplay exe)*

## Usage:

1. Add to your project (Or install with nuget **[Soon]**)
2. Add "using UbiParser;"

3. Use it:

`var parsedManifest = UbiParser.Parsers.ParseManifestFile("myUbiManifest");`

or:

`var parsedManifest = Parsers.ParseManifestFile("myUbiManifest");`

You can get what are inside of their Cache files. Like the CompressionMethod from the manifest (If you parsed before):

`Console.WriteLine(parsedManifest.CompressionMethod);`

# Ubi Parser GUI

A simple Windows GUI Application for parsing without code.\
Easy to use (I hope), and DARK mode.\
If you want more feature, make a Pull Request or Issue!

# Informations

Supported DotNet Version: 6.0\
Supported Latest Uplay Version: 10667 (From version.txt) , 131.0.10667 (File and product version of upc.exe)\

# Helping

*Help me, I am not stable...*\
For any reason if I don't update or loss or I abandon this project.\
Or if you want to join, etc.\
You can contact me:

Contact Mail: UplayDB@protonmail.com | Subject: UBI-PARSER
