@echo off

SET dir=%~dp0
call "%dir%..\config\path_config.bat"

%cipher% vig -k %vig_key% -i %source_file% -o %encoded_file%

pause