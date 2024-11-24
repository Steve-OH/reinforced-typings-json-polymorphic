The C# project in this repository demonstrates a bug in Reinforced.Typings 1.6.5. If the following are true:
* System.Text.Json 9.0.0 is included in the project's dependencies, and
* The `JsonPolymorphic` attribute is used

Then Reinforced.Typings fails with an RT0999 error: Could not load file or assembly 'System.Text.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'. The system cannot find the file specified.

See https://github.com/reinforced/Reinforced.Typings/issues/284
