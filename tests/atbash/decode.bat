@echo off

SET dir=%~dp0

call "%dir%..\config\path_config.bat"

%cipher% atb -d -i %encoded_file% -o %decoded_file%

pause