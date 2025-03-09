import { ref, computed } from "vue";
import { defineStore } from "pinia";
import axios from "axios";

export const useFoursStore = defineStore("fours", () => {
  const fours = ref([]);
  const currentFour = ref({
    a:0,
    b:0,
    c:0,
    d:0,
    id:0,
  });

  const fetchFours = async () => {
    try {
      const response = await axios.get("https://localhost:7082/fours");
      fours.value = response.data;
    } catch {}
  };

  const getFoursById = async (id) => {
    try {
      const response = await axios.get(`https://localhost:7082/fours/${id}`);
      currentFour.value = response.data
    } catch {}
  };

  const postFour = async (four) => {
    const t = [four.value.a,four.value.b,four.value.v,four.value.d];
    try {
      await axios.post(`https://localhost:7082/fours`,four);
      console.log(t)
    } catch {}
  };

  return { fours, currentFour, fetchFours, getFoursById, postFour };
});
