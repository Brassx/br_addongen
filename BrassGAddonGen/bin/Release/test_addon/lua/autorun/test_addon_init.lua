local gm_cl_files = file.Find('test_addon/client/*.lua', 'LUA'); 
local gm_sh_files = file.Find('test_addon/shared/*.lua', 'LUA'); 
local gm_sv_files = file.Find('test_addon/server/*.lua', 'LUA'); 
if (SERVER) then
	AddCSLuaFile('test_addon/config/config.lua');
end
include('test_addon/config/config.lua');
for k, v in pairs(gm_cl_files) do
	if (SERVER) then
		AddCSLuaFile('test_addon/client/'..v);
	else
		include('test_addon/client/'..v);
	end
end
if (SERVER) then
	for k, v in pairs(gm_sv_files) do
		include('test_addon/server/'..v);
	end
end
for k , v in pairs(gm_sh_files) do
	include('test_addon/shared/'..v);
	if (SERVER) then
		AddCSLuaFile('test_addon/shared/'..v);
	end
end
