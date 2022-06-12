import React from 'react'
import 'bootstrap/dist/css/bootstrap.min.css';

function Navbars() {
  return (
    <nav class="navbar navbar-expand-lg bg-light">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Ana Sayfa</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Kullanıcı</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Daire</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Fatura</a>
        </li>
      </ul>
      <li class="nav-item"style={{"listStyleType":"None"}}>
          <a class="nav-link" href="#" ><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-arrow-90deg-right" viewBox="0 0 16 16">
  <path fill-rule="evenodd" d="M14.854 4.854a.5.5 0 0 0 0-.708l-4-4a.5.5 0 0 0-.708.708L13.293 4H3.5A2.5 2.5 0 0 0 1 6.5v8a.5.5 0 0 0 1 0v-8A1.5 1.5 0 0 1 3.5 5h9.793l-3.147 3.146a.5.5 0 0 0 .708.708l4-4z"/>
</svg></a>
        </li>


    </div>
  </div>
</nav>
  )
}

export default Navbars