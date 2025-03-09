<script setup>
import { RouterLink, RouterView } from 'vue-router'

</script>

<template>
  <nav class="navbar navbar-dark bg-dark navbar-expand-lg sticky-top p-3">
    <div class="container">
      <button
        class="navbar-toggler"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#navbarNav"
        aria-controls="navbarNav"
        aria-expanded="false"
        aria-label="Navigáció váltása"
      >
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarNav">
        <ul class="navbar-nav ms-auto">
          <li class="nav-item">
            <RouterLink class="nav-link menuitem" to="/">Táblajáték</RouterLink>
          </li>
          <li class="nav-item">
            <RouterLink class="nav-link menuitem" to="/fours">Számnégyesek</RouterLink>
          </li>
        </ul>
      </div>
    </div>
  </nav>

  <div class="container mt-4">
    <RouterView />
  </div>
</template>

<style scoped>

.nav-link {
  font-size: 1.2rem;
  font-weight: 500;
  color: white !important;
  transition: 0.3s ease-in-out;
}

.nav-link:hover {
  color: #f8d210 !important;
}


.router-link-active {
  font-weight: bold;
  border-bottom: 2px solid #f8d210;
}
</style>
