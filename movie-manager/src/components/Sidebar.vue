<template>
    <aside>

        <h3>Watcher</h3>
        <div class="menu">
            <router-link class="button active" to="/">Movies</router-link>
            <router-link class="button" to="/genres">Genres</router-link>
        </div>
        
    </aside>
</template>

<script setup>

</script>

<style lang="scss" scoped>
aside {
    display: flex;
    flex-direction: column;
    // width: calc(2rem + 32px);
    width: 10rem;
    min-height: 100vh;
    overflow: hidden;

    background-color: var(--color-primary);
    color: white;

    transition: 0.2s ease-out;

    h3 {
        padding: 1rem;
    }

    .flex {
        flex: 1 1 0;
    }

    .button {
        display: block;
        padding: 0.5rem 1rem;
        color: white;
        text-decoration: none;
        cursor: pointer;
        transition: 0.2s ease-out;
        width:100%;

        &:hover {
            background-color: var(--color-primary-light);
        }

        &.active {
            background-color: var(--color-primary-dark);
            border-right: 5px solid var(--color-primary-darker);
        }
    }
}
</style>