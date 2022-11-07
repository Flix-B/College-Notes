# HTML

Hyper Text Markup Language
Cascading Style Sheets
webpages can be made up of HTML CSS Javascript 
HTML is a tag based markup language e.g <head> .. </head> 

Anything in <head> affects the browser
Anything in <body> affects the webpage 
use emmet to start HTML file by typing "!" and pressing tab
Link CSS to HTML file using <link> tag 
use <div> to seperate page into blocks - then embed 
can also use <header> , <section>, <article>, <nav>, <footer>
use fonts.googe.com to get new fonts
new fonts can be linked in HTML or imported in CSS
use @import url("url.com") to import fonts into CSS
ctrl + shift + i to open dev tools in chrome - can be used to test mobile site 

need to use CSS selectors - (<div> variants) or tags when setting CSS setting to apply to individual parts
can also set a ID using " id ="a name" " (unique in the page)
can also use classes, which allow targeting of multiple elements,
in CSS, to reference selectors:
 id = #
 class = . 

ca define div ids when defining the div eg:
<div #231>.....</div>

can define div classes with:
<div class="cards"> .... </div> 
Sizing in CSS - can use pixels, ems, rems, % .
pixels = actual physisical pixels#
% = percentage of start size
rem = standard text size so 1 rem - 16px 
ems = 

can target layered tags (eg <h1> inside <nav>) by doing "nav h1{ ...
                                                                
## CSS Flexbox

layout items inside a <div>
in CSS, when referenceing divisions:
type "display: flex;" otherwise will recieve "display: block;"

block = big squared off area around each element
flex = efficient, dynamic box around each element

can use "align-items" with "flex start" and "flex end" and "center"
can use "justify-content:" with same as above to do horzontal location 
can also do "flex-direction: " with "vertical" or "horizontal" to change whole system  

## CSS Grid

Is used for manipulating divs themselves 
Useful for splitting pages up into large blocks that contain divs
Not affected by order that is written in 
s
stayndard measurement = fr  can also use normal like px - or can use vh / vw where 10vh = 10% of vertical height

e.g 
div.top{top}

<div>

In the CSS:

.top{
    grid-area:top;
    
}    

.left{
    grid-area:left;

}
body{
    display: grid;
    grid-templates-columns: 25vw 75vw; # means there will be 2 columns of 25 and 75 vertical width
    grid-templates-rows; 20vh 60vh 20vh # means there will be 3 rows of 20 60 20 vertical height
    grid-templates-areas: # defining layout per row
    "top top"
    "left main"
    "footer footer"
    ;
    }

                                                            