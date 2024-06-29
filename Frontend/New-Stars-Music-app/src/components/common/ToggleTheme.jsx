import React, { useContext } from "react";

import { useTheme } from "../../services/contexts/ThemeProvider";

const ToggleTheme = () => {
  const { theme, toggleTheme } = useTheme();
  
  const onToggleThemeHandler = () => {
    toggleTheme();
    console.log(theme);
  };
  return (
    <label className="relative inline-flex items-center cursor-pointer">
      <input
        className="sr-only peer"
        value=""
        type="checkbox"
        onClick={onToggleThemeHandler}
      />
      <div className="w-20 h-10 rounded-full ring-0 peer duration-500 outline-none bg-[#383838] overflow-hidden before:flex before:items-center before:justify-center after:flex after:items-center after:justify-center before:content-['🌑'] before:absolute before:h-8 before:w-8 before:top-1/2 before:bg-[#1d1d1d] before:rounded-full before:left-1 before:-translate-y-1/2 before:transition-all before:duration-700 peer-checked:before:opacity-0 peer-checked:before:rotate-90 peer-checked:before:-translate-y-full shadow-lg shadow-gray-0 peer-checked:shadow-lg  peer-checked:bg-white after:content-['☀️'] after:absolute after:bg-gray-400 after:rounded-full after:top-[4px] after:right-1 after:translate-y-full after:w-8 after:h-8 after:opacity-0 after:transition-all after:duration-700 peer-checked:after:opacity-100 peer-checked:after:rotate-180 peer-checked:after:translate-y-0"></div>
    </label>
  );
};

export default ToggleTheme;
