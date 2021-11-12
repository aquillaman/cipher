@echo off

SET dir=%~dp0
call "%dir%..\config\path_config.bat"

%cipher% atb -i %source_file% -o %encoded_file%

pause