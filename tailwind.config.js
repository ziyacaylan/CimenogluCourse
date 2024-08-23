/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [],
    theme: {
        extend: {
            keyframes: {
                slideDown: {
                    "0%": { height: "0" },
                    "100%": { height: "var(--height)" },
                },
                slideUp: {
                    "0%": { height: "var(--height)" },
                    "100%": { height: "0" },
                },
            },
            animation: {
                slideDown: "slideDown 0.5s ease-out forwards",
                slideUp: "slideUp 0.5s ease-out forwards",
            },
        },
    },
    plugins: [],
};
