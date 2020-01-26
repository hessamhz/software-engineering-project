<template>
    <v-app class="grey lighten-5">
        <v-content>
            <toolbar></toolbar>
            <v-layout row>
                <v-flex lg2>
                    <navbar></navbar>
                </v-flex>
                <v-flex lg10>
                    <v-container width="120vw" fluid>
                        <v-container class="ml-0 mt-2 mb-6 mr-0">
                            <span class="text-lg-left font-weight-bold font-weight-black" style="font-size: xx-large">Categories</span>
                        </v-container>
                    <v-row class="mr-4">
                        <v-col cols="12" lg="4">
                            <v-card height="30vh" @click="open()">
                                <v-container class="mx-0 px-0 py-0">
                                <v-img cover aspect-ratio="1.7" src="https://i.pinimg.com/originals/bb/1e/21/bb1e212ab15fbfd8282a01e662770678.jpg">
                                <v-card-text style="bottom: 0; position: absolute; background-color: rgba(256,256,256,0.8); height: 10vh;">
                                    <span class="font-weight-bold font-weight-black" style="font-size: medium;">Repairement</span>
                                    <v-container class="ml-0 pl-0 pb-4">
                                        You can see the subcategory by clicking here
                                        <v-icon class="pl-2 ml-12 mr-0 pr-0">mdi-chevron-right</v-icon>
                                    </v-container>
                                </v-card-text>

                                </v-img>
                                </v-container>
                            </v-card>

                        </v-col>
                        <v-col cols="12" lg="4">
                            <v-card height="30vh">
                                <v-container class="mx-0 px-0 py-0">
                                    <v-img cover aspect-ratio="1.7" src="https://i.pinimg.com/originals/bb/1e/21/bb1e212ab15fbfd8282a01e662770678.jpg">
                                        <v-card-text style="bottom: 0; position: absolute; background-color: rgba(256,256,256,0.8); height: 10vh;">
                                            <span class="font-weight-bold font-weight-black" style="font-size: medium;">Repairement</span>
                                            <v-container class="ml-0 pl-0 pb-4">
                                                You can see the subcategory by clicking here
                                                <v-icon class="pl-2 ml-12 mr-0 pr-0">mdi-chevron-right</v-icon>
                                            </v-container>
                                        </v-card-text>

                                    </v-img>
                                </v-container>
                            </v-card>
                        </v-col>
                        <v-col cols="12" lg="4">
                            <v-card height="30vh">
                                <v-container class="mx-0 px-0 py-0">
                                    <v-img cover aspect-ratio="1.7" src="https://i.pinimg.com/originals/bb/1e/21/bb1e212ab15fbfd8282a01e662770678.jpg">
                                        <v-card-text style="bottom: 0; position: absolute; background-color: rgba(256,256,256,0.8); height: 10vh;">
                                            <span class="font-weight-bold font-weight-black" style="font-size: medium;">Repairement</span>
                                            <v-container class="ml-0 pl-0 pb-4">
                                                You can see the subcategory by clicking here
                                                <v-icon class="pl-2 ml-12 mr-0 pr-0">mdi-chevron-right</v-icon>
                                            </v-container>
                                        </v-card-text>

                                    </v-img>
                                </v-container>
                            </v-card>
                        </v-col>
                    </v-row>
                        <v-row class="mr-4" v-if="op">
                            <v-container>
                                <v-layout row >
                                    <v-flex lg6>
                                        <v-card>
                                            <v-img cover aspect-ratio="1.7" src="https://i.pinimg.com/originals/bb/1e/21/bb1e212ab15fbfd8282a01e662770678.jpg">
                                            </v-img>
                                        </v-card>
                                    </v-flex>
                                    <v-flex lg6>
                                        <v-card>
                                            <v-card-text>
                                                <span>Praesent placerat risus quis eros.</span><br><span style="font-style:normal;font-weight:normal;">   Fusce pellentesque suscipit nibh.<br/>   Vestibulum commodo felis quis tortor.<br/>   Ut aliquam sollicitudin leo.<br/>   Cras iaculis ultricies nulla.</span><br>
                                            </v-card-text>
                                        </v-card>
                                    </v-flex>
                                </v-layout>
                            </v-container>
                        </v-row>
                    <v-row class="mr-4" v-if="!op">
                        <v-col cols="12" lg="4">
                            <v-card height="30vh">
                                <v-container class="mx-0 px-0 py-0">
                                    <v-img cover aspect-ratio="1.7" src="https://i.pinimg.com/originals/bb/1e/21/bb1e212ab15fbfd8282a01e662770678.jpg">
                                        <v-card-text style="bottom: 0; position: absolute; background-color: rgba(256,256,256,0.8); height: 10vh;">
                                            <span class="font-weight-bold font-weight-black" style="font-size: medium;">Repairement</span>
                                            <v-container class="ml-0 pl-0 pb-4">
                                                You can see the subcategory by clicking here
                                                <v-icon class="pl-2 ml-12 mr-0 pr-0">mdi-chevron-right</v-icon>
                                            </v-container>
                                        </v-card-text>

                                    </v-img>
                                </v-container>
                            </v-card>
                        </v-col>
                        <v-col cols="12" lg="4">
                            <v-card height="30vh">
                                <v-container class="mx-0 px-0 py-0">
                                    <v-img cover aspect-ratio="1.7" src="https://i.pinimg.com/originals/bb/1e/21/bb1e212ab15fbfd8282a01e662770678.jpg">
                                        <v-card-text style="bottom: 0; position: absolute; background-color: rgba(256,256,256,0.8); height: 10vh;">
                                            <span class="font-weight-bold font-weight-black" style="font-size: medium;">Repairement</span>
                                            <v-container class="ml-0 pl-0 pb-4">
                                                You can see the subcategory by clicking here
                                                <v-icon class="pl-2 ml-12 mr-0 pr-0">mdi-chevron-right</v-icon>
                                            </v-container>
                                        </v-card-text>

                                    </v-img>
                                </v-container>
                            </v-card>
                        </v-col>
                        <v-col cols="12" lg="4">
                            <v-card height="30vh">
                                <v-container class="mx-0 px-0 py-0">
                                    <v-img cover aspect-ratio="1.7" src="https://i.pinimg.com/originals/bb/1e/21/bb1e212ab15fbfd8282a01e662770678.jpg">
                                        <v-card-text style="bottom: 0; position: absolute; background-color: rgba(256,256,256,0.8); height: 10vh;">
                                            <span class="font-weight-bold font-weight-black" style="font-size: medium;">Repairement</span>
                                            <v-container class="ml-0 pl-0 pb-4">
                                                You can see the subcategory by clicking here
                                                <v-icon class="pl-2 ml-12 mr-0 pr-0">mdi-chevron-right</v-icon>
                                            </v-container>
                                        </v-card-text>

                                    </v-img>
                                </v-container>
                            </v-card>
                        </v-col>
                    </v-row>
                    </v-container>
                </v-flex>
            </v-layout>
        </v-content>
    </v-app>
</template>

<script>
    //import Toolbar from "./toolbar";
    import Toolbar from "./toolbar";
    import Navbar from "./navbar";
    export default {
        name: "taskee",
        op: false,
     components: {Navbar, Toolbar},
        methods: {
            open(){
                this.op = true;
            }
        }
        // components: {Toolbar}
    }
</script>

<style scoped>

</style>