<template>
  <div>
    <div class="modal">
      <div class="modalMask"></div>
      <div class="popup">
        <div class="dialogHeader">
          <button class="closeDialog" @click="closePopup">
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="24"
              height="24"
              viewBox="0 0 24 24"
              fill="none"
              stroke="currentColor"
              stroke-width="2"
              stroke-linecap="round"
              stroke-linejoin="round"
              class="feather feather-x"
            >
              <line x1="18" y1="6" x2="6" y2="18"></line>
              <line x1="6" y1="6" x2="18" y2="18"></line>
            </svg>
          </button>
          <h3>Xóa dữ liệu</h3>
        </div>
        <div class="popupContent">
          <div class="question">
            <i
              id="iconquestion"
              class="fa fa-question-circle fa-4x"
              aria-hidden="true"
            ></i>
          </div>
          <div class="message">
            Bạn có chắc muốn xóa cửa hàng
            <span>{{ nameNeedDelete }}</span>
            khỏi danh sách cửa hàng hay không ?
          </div>
        </div>
        <hr />
        <div class="dialogFooter" style="justify-content: flex-end">
          <div class="dialogFooterButtonBox">
            <button
              class="dialogFooterButton"
              id="buttonDelete"
              @click="deleteRestaurant"
            >
              <div class="iconDelete"></div>
              Xóa
            </button>
            <button
              class="dialogFooterButton"
              id="buttonCancel"
              @click="closePopup"
            >
              <div class="iconCancel"></div>
              Hủy bỏ
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import * as axios from "axios";
export default {
  name: "PopupDelete",
  props: {
    idToDelete: String,
    nameNeedDelete: String,
  },

  methods: {
    /**
     * đóng popup
     */
    closePopup() {
      this.$store.dispatch("closePopup");
    },
    /**
     * Xóa cửa hàng
     * Created by Vtt
     */
    deleteRestaurant() {
      // gọi api
      const response = axios
        .delete("https://localhost:44305/api/v1/restaurants/" + this.idToDelete)
        .catch((e) => console.log(e));
      if (response) {
        //nếu xóa thành công thì đóng popup
        this.closePopup();
        //hiện noti
        this.$notify({
          title: "Important message",
          text: "Xóa thành công cửa hàng!",
        });
        // load lai trang sau 2s
        setTimeout(() => location.reload(), 2000);
      }
    },
  },
  data() {
    return {
      myVar: "",
      showPopup: false,
      restaurants: [],
    };
  },
};
</script>

<style scoped>
span {
  font-weight: bold;
}
.question {
  height: 60px;
  width: 60px;
  align-items: center;
}
#iconquestion {
  color: #026b97;
  padding: 14px;
}
</style>