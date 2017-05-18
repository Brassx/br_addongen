local gm_cl_files = file.Find('ADDON_NAME/client/*.lua', 'LUA'); 
local gm_sh_files = file.Find('ADDON_NAME/shared/*.lua', 'LUA'); 
local gm_sv_files = file.Find('ADDON_NAME/server/*.lua', 'LUA'); 
for k, v in pairs(gm_cl_files) do
	if (SERVER) then
		AddCSLuaFile('ADDON_NAME/client/'..v);
	else
		include('ADDON_NAME/client/'..v);
	end
end
if (SERVER) then 
	for k, v in pairs(gm_sv_files) do
		include('ADDON_NAME/server/'..v);
	end
end
for k , v in pairs(gm_sh_files) do
	include('ADDON_NAME/shared/'..v);
	if (SERVER) then
		AddCSLuaFile('ADDON_NAME/shared/'..v);
	end
end
