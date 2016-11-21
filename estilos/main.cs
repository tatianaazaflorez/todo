* {
  margin: 0;
  padding: 0; }

body {
  background: #FFFFFA; }

header {
  width: 100%; }

header nav {
  width: 90%;
  max-width: 1000px;
  margin: 20px auto;
  background: #024959; }

.menu_bar {
  display: none; }

header nav ul {
  overflow: hidden;
  list-style: none; }

header nav ul li {
  float: left; }

header nav ul li a {
  color: #fff;
  padding: 20px;
  display: block;
  text-decoration: none; }

header nav ul li span {
  margin-right: 10px; }

header nav ul li a:hover {
  background: #037E8C; }

section {
  padding: 20px; }

@media screen and (max-width: 800px) {
  header nav {
    width: 80%;
    height: 100%;
    left: -100%;
    margin: 0;
    position: fixed;
    z-index: 20; }

  header nav ul li {
    display: block;
    float: none;
    border-bottom: 1px solid rgba(255, 255, 255, 0.3); }

  .menu_bar {
    display: block;
    width: 100%;
    background: #ccc; }

  .menu_bar .bt-menu {
    display: block;
    padding: 20px;
    background: #024959;
    color: #fff;
    text-decoration: none;
    font-weight: bold;
    font-size: 25px;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box; }

  .menu_bar span {
    float: right;
    font-size: 40px; } }
* {
  margin: 0;
  padding: 0; }

body {
  background: #f2f2f2; }

.main {
  width: 90%;
  max-width: 1000px;
  margin: 20px auto; }

.slides {
  width: 100%; }

.slides img {
  width: 100%; }

.slidesjs-pagination {
  background: #424242;
  list-style: none;
  overflow: hidden; }

.slidesjs-pagination li {
  float: left; }

.slidesjs-pagination li a {
  display: block;
  padding: 10px 20px;
  color: #fff;
  text-decoration: none; }

.slidesjs-pagination li a:hover {
  background: #000; }

.slides .active {
  background: #000; }

.slidesjs-navigation {
  background: #000;
  color: #fff;
  text-decoration: none;
  display: inline-block;
  padding: 13.5px 20px;
  float: right; }

#wrapper-add-todo {
  text-align: center;
  padding: 16px 0;
  border-bottom: 1px solid #004D40; }

#wrapper-todo {
  display: flex;
  justify-content: space-around;
  flex-wrap: wrap; }

#wrapper-todo .todo-item {
  flex-basis: 18%;
  background: #004D40;
  text-align: center;
  padding: 20px;
  margin-top: 12px;
  color: #fff;
  position: relative; }

#wrapper-todo .todo-item .remove {
  transition: opacity 0.5s linear;
  position: absolute;
  width: 20px;
  height: 20px;
  background: #fff url("../img/img.png");
  top: 0;
  right: 0;
  cursor: pointer;
  background-size: 20px 20px;
  opacity: 0.5; }
  #wrapper-todo .todo-item .remove #wrapper-todo .todo-item .remove:hover {
    opacity: 1;
    height: 40%;
    clear: both; }

/*# sourceMappingURL=main.cs.map */
