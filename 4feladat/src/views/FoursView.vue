<script setup>
import { useFoursStore } from "@/stores/fours.js";
import { onMounted, ref } from "vue";

const foursStore = useFoursStore();

const f = ref(false);
const fId = ref(0);

const newFour = ref({
  a: 0,
  b:0,
  c:0,
  d:0
})

const getFours = async () => {
  await foursStore.getFoursById(fId.value);
  f.value = true;
  console.log(f.value);
};

const postFours = async() =>{
  await foursStore.postFour(newFour);
}

onMounted(async () => {
  await foursStore.fetchFours();
});
</script>

<template>
  <div class="container">
    <div class="form-group card bg-dark text-light p-3">
      <h2>Új négyes:</h2>
      <label for="" class="form-label">Adja meg a számnégyes számait:</label>
      <input v-model="newFour.a" class="form-control mt-3" type="number" />
      <input v-model="newFour.b" class="form-control mt-3" type="number" />
      <input v-model="newFour.c" class="form-control mt-3" type="number" />
      <input v-model="newFour.d" class="form-control mt-3" type="number" />
      <button class="btn btn-primary mt-3" @click="postFours">Hozzáadás</button>
    </div>
    <div class="form-group card bg-dark text-light p-3 mt-3">
      <h2>Négyes lekérése:</h2>
      <label for="id" class="form-label">Adja meg a számnégyes id-jét:</label>
      <input
        v-model="fId"
        class="form-control mt-3"
        type="number"
        id="id"
        name="id"
      />
      <button class="btn btn-primary mt-3" @click="getFours">
        Megjelenítés
      </button>
      <hr class="bg-white" />
      <div v-if="f !== false">{{ foursStore.currentFour.a }}; {{ foursStore.currentFour.b }}; {{ foursStore.currentFour.c }}; {{ foursStore.currentFour.d }}</div>
    </div>
  </div>
</template>
