set PATH=%PATH%;C:\Program Files (x86)\sox-14-4-2
sox -r 8000 -t vox %1 -t wav %2
exit