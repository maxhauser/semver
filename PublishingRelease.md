# Publishing a Release

## Preparing for the Release

* Make all changes for the release on `master` (except for the readme).
* Have a `vX.Y.Z-readme` branch ready with the readme for the next version.
* Prepare a branch in the docs repo with updated docs for the new version and verify the doc
  comments for the new version.

## Steps to Publish Release

1. Create an *annotated* tag of the version number being published prefixed with "v". The tag description should match the tag name.
2. Wait for the build of that tag to complete in Appveyor.
3. Download the nupkg and snupkg files from the assets tab of Appveyor.
4. Upload those to NuGet with the new readme from the readme branch.
   * Remove the build and NuGet status from the top of the readme before putting it in NuGet.

## After Publishing a Release

These steps only need to be done for a non-prerelease version.

1. Create a release from the tag on github.
   * Write up the changes in that version.
   * Attach the nupkg and snupkg files to the release in github.
2. Merge the `vX.Y.Z-readme` branch into `master`.
3. Create a new `vX.Y.Z-readme` branch for the next version.
4. Mark the milestone, and any included issues, done with the current date.
5. Update the `PublicAPI` files to reflect the newly published APIs
6. Update the benchmark to reference the new version as the previous version.