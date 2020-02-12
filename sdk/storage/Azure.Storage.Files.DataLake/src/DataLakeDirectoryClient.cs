﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Files.DataLake.Models;
using Metadata = System.Collections.Generic.IDictionary<string, string>;

namespace Azure.Storage.Files.DataLake
{
    /// <summary>
    /// A DirectoryClient represents a URI to the Azure DataLake service allowing you to manipulate a directory.
    /// </summary>
    public class DataLakeDirectoryClient : DataLakePathClient
    {
        #region ctors
        /// <summary>
        /// Initializes a new instance of the <see cref="DataLakeDirectoryClient"/>
        /// class for mocking.
        /// </summary>
        protected DataLakeDirectoryClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataLakeDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the file system, and the path of the
        /// directory.
        /// </param>
        public DataLakeDirectoryClient(Uri directoryUri)
            : this(directoryUri, (HttpPipelinePolicy)null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataLakeDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the file system, and the path of the
        /// directory.
        /// </param>
        /// <param name="options">
        /// Optional <see cref="DataLakeClientOptions"/> that define the transport
        /// pipeline policies for authentication, retries, etc., that are
        /// applied to every request.
        /// </param>
        public DataLakeDirectoryClient(Uri directoryUri, DataLakeClientOptions options)
            : this(directoryUri, (HttpPipelinePolicy)null, options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataLakeDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the file system, and the path of the
        /// directory.
        /// </param>
        /// <param name="credential">
        /// The shared key credential used to sign requests.
        /// </param>
        public DataLakeDirectoryClient(Uri directoryUri, StorageSharedKeyCredential credential)
            : this(directoryUri, credential.AsPolicy(), null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataLakeDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the file system, and the path of the
        /// directory.
        /// </param>
        /// <param name="credential">
        /// The shared key credential used to sign requests.
        /// </param>
        /// <param name="options">
        /// Optional client options that define the transport pipeline
        /// policies for authentication, retries, etc., that are applied to
        /// every request.
        /// </param>
        public DataLakeDirectoryClient(Uri directoryUri, StorageSharedKeyCredential credential, DataLakeClientOptions options)
            : this(directoryUri, credential.AsPolicy(), options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataLakeDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the file system, and the path of the
        /// directory.
        /// </param>
        /// <param name="credential">
        /// The token credential used to sign requests.
        /// </param>
        public DataLakeDirectoryClient(Uri directoryUri, TokenCredential credential)
            : this(directoryUri, credential.AsPolicy(), null)
        {
            Errors.VerifyHttpsTokenAuth(directoryUri);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataLakeDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the file system, and the path of the
        /// directory.
        /// </param>
        /// <param name="credential">
        /// The token credential used to sign requests.
        /// </param>
        /// <param name="options">
        /// Optional client options that define the transport pipeline
        /// policies for authentication, retries, etc., that are applied to
        /// every request.
        /// </param>
        public DataLakeDirectoryClient(Uri directoryUri, TokenCredential credential, DataLakeClientOptions options)
            : this(directoryUri, credential.AsPolicy(), options)
        {
            Errors.VerifyHttpsTokenAuth(directoryUri);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataLakeDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the file system, and the path of the
        /// directory.
        /// </param>
        /// <param name="authentication">
        /// An optional authentication policy used to sign requests.
        /// </param>
        /// <param name="options">
        /// Optional client options that define the transport pipeline
        /// policies for authentication, retries, etc., that are applied to
        /// every request.
        /// </param>
        internal DataLakeDirectoryClient(Uri directoryUri, HttpPipelinePolicy authentication, DataLakeClientOptions options)
            : base(directoryUri, authentication, options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataLakeDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the file system, and the path of the
        /// directory.
        /// </param>
        /// <param name="pipeline">
        /// The transport pipeline used to send every request.
        /// </param>
        /// <param name="version">
        /// The version of the service to use when sending requests.
        /// </param>
        /// <param name="clientDiagnostics">
        /// The <see cref="ClientDiagnostics"/> instance used to create
        /// diagnostic scopes every request.
        /// </param>
        internal DataLakeDirectoryClient(Uri directoryUri, HttpPipeline pipeline, DataLakeClientOptions.ServiceVersion version, ClientDiagnostics clientDiagnostics)
            : base(directoryUri, pipeline, version, clientDiagnostics)
        {
        }
        #endregion ctors

        /// <summary>
        /// Creates a new <see cref="DataLakeFileClient"/> object by appending
        /// <paramref name="fileName"/> to the end of <see cref="Uri"/>.  The
        /// new <see cref="DataLakeFileClient"/> uses the same request policy
        /// pipeline as the <see cref="DataLakeDirectoryClient"/>.
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <returns>A new <see cref="DataLakeFileClient"/> instance.</returns>
        public virtual DataLakeFileClient GetFileClient(string fileName)
            => new DataLakeFileClient(Uri.AppendToPath(fileName), Pipeline, Version, ClientDiagnostics);

        /// <summary>
        /// Creates a new <see cref="DataLakeDirectoryClient"/> object by appending
        /// <paramref name="subdirectoryName"/> to the end of <see cref="Uri"/>.
        /// The new <see cref="DataLakeDirectoryClient"/> uses the same request policy
        /// pipeline as the <see cref="DataLakeDirectoryClient"/>.
        /// </summary>
        /// <param name="subdirectoryName">The name of the subdirectory.</param>
        /// <returns>A new <see cref="DataLakeDirectoryClient"/> instance.</returns>
        public virtual DataLakeDirectoryClient GetSubDirectoryClient(string subdirectoryName)
            => new DataLakeDirectoryClient(Uri.AppendToPath(subdirectoryName), Pipeline, Version, ClientDiagnostics);

        #region Create
        /// <summary>
        /// The <see cref="Create"/> operation creates a file or directory.
        ///
        /// For more information, see https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/create.
        /// </summary>
        /// <param name="httpHeaders">
        /// Optional standard HTTP header properties that can be set for the
        /// new file or directory..
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata to set for this file or directory..
        /// </param>
        /// <param name="permissions">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account. Sets POSIX access
        /// permissions for the file owner, the file owning group, and others. Each class may be granted read,
        /// write, or execute permission. The sticky bit is also supported. Both symbolic (rwxrw-rw-) and 4-digit
        /// octal notation (e.g. 0766) are supported.
        /// </param>
        /// <param name="umask">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account.
        /// When creating a file or directory and the parent folder does not have a default ACL,
        /// the umask restricts the permissions of the file or directory to be created. The resulting
        /// permission is given by p bitwise-and ^u, where p is the permission and u is the umask. For example,
        /// if p is 0777 and u is 0057, then the resulting permission is 0720. The default permission is
        /// 0777 for a directory and 0666 for a file. The default umask is 0027. The umask must be specified
        /// in 4-digit octal notation (e.g. 0766).
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on the creation of this file or directory..
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathInfo}"/> describing the
        /// newly created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response<PathInfo> Create(
            PathHttpHeaders httpHeaders = default,
            Metadata metadata = default,
            string permissions = default,
            string umask = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(Create)}");

            try
            {
                scope.Start();

                return base.Create(
                    PathResourceType.Directory,
                    httpHeaders,
                    metadata,
                    permissions,
                    umask,
                    conditions,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="Create"/> operation creates a file or directory.
        ///
        /// For more information, see https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/create.
        /// </summary>
        /// <param name="httpHeaders">
        /// Optional standard HTTP header properties that can be set for the
        /// new file or directory..
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata to set for this file or directory..
        /// </param>
        /// <param name="permissions">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account. Sets POSIX access
        /// permissions for the file owner, the file owning group, and others. Each class may be granted read,
        /// write, or execute permission. The sticky bit is also supported. Both symbolic (rwxrw-rw-) and 4-digit
        /// octal notation (e.g. 0766) are supported.
        /// </param>
        /// <param name="umask">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account.
        /// When creating a file or directory and the parent folder does not have a default ACL,
        /// the umask restricts the permissions of the file or directory to be created. The resulting
        /// permission is given by p bitwise-and ^u, where p is the permission and u is the umask. For example,
        /// if p is 0777 and u is 0057, then the resulting permission is 0720. The default permission is
        /// 0777 for a directory and 0666 for a file. The default umask is 0027. The umask must be specified
        /// in 4-digit octal notation (e.g. 0766).
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on the creation of this file or directory..
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathInfo}"/> describing the
        /// newly created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response<PathInfo>> CreateAsync(
            PathHttpHeaders httpHeaders = default,
            Metadata metadata = default,
            string permissions = default,
            string umask = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(Create)}");

            try
            {
                scope.Start();

                return await base.CreateAsync(
                    PathResourceType.Directory,
                    httpHeaders,
                    metadata,
                    permissions,
                    umask,
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Create

        #region Delete
        /// <summary>
        /// The <see cref="Delete"/> operation marks the specified path
        /// deletion. The path is later deleted during
        /// garbage collection.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/delete" />.
        /// </summary>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// deleting this path.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> on successfully deleting.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response Delete(
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(Delete)}");

            try
            {
                scope.Start();

                return base.Delete(
                    recursive: true,
                    conditions,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="DeleteAsync"/> operation marks the specified path
        /// deletion. The path is later deleted during
        /// garbage collection.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/delete" />.
        /// </summary>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// deleting this path.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> on successfully deleting.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response> DeleteAsync(
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(Delete)}");

            try
            {
                scope.Start();

                return await base.DeleteAsync(
                    recursive: true,
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Delete

        #region Rename
        /// <summary>
        /// The <see cref="Rename"/> operation renames a Directory.
        ///
        /// For more information, see https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/create.
        /// </summary>
        /// <param name="destinationPath">
        /// The destination path to rename the path to.
        /// </param>
        /// <param name="destinationFileSystem">
        /// Optional destination file system.  If null, path will be renamed within the
        /// current file system.
        /// </param>
        /// <param name="sourceConditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on the source on the creation of this file or directory.
        /// </param>
        /// <param name="destinationConditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on the creation of this file or directory.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{DataLakeDirectoryClient}"/> for the
        /// newly created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public new virtual Response<DataLakeDirectoryClient> Rename(
            string destinationPath,
            string destinationFileSystem = default,
            DataLakeRequestConditions sourceConditions = default,
            DataLakeRequestConditions destinationConditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(Rename)}");

            try
            {
                scope.Start();

                Response<DataLakePathClient> response = base.Rename(
                    destinationFileSystem,
                    destinationPath,
                    sourceConditions,
                    destinationConditions,
                    cancellationToken);

                return Response.FromValue(
                    new DataLakeDirectoryClient(response.Value.DfsUri, response.Value.Pipeline, response.Value.Version, response.Value.ClientDiagnostics),
                    response.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="RenameAsync"/> operation renames a file or directory.
        ///
        /// For more information, see https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/create.
        /// </summary>
        /// <param name="destinationPath">
        /// The destination path to rename the path to.
        /// </param>
        /// <param name="destinationFileSystem">
        /// Optional destination file system.  If null, path will be renamed within the
        /// current file system.
        /// </param>
        /// <param name="sourceConditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on the source on the creation of this file or directory.
        /// </param>
        /// <param name="destinationConditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on the creation of this file or directory.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{DataLakeDirectoryClient}"/> for
        /// the newly created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public new virtual async Task<Response<DataLakeDirectoryClient>> RenameAsync(
            string destinationPath,
            string destinationFileSystem = default,
            DataLakeRequestConditions sourceConditions = default,
            DataLakeRequestConditions destinationConditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(Rename)}");

            try
            {
                scope.Start();

                Response<DataLakePathClient> response = await base.RenameAsync(
                    destinationFileSystem,
                    destinationPath,
                    sourceConditions,
                    destinationConditions,
                    cancellationToken)
                    .ConfigureAwait(false);

                return Response.FromValue(
                    new DataLakeDirectoryClient(response.Value.DfsUri, response.Value.Pipeline, response.Value.Version, response.Value.ClientDiagnostics),
                    response.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Rename

        #region Get Access Control
        /// <summary>
        /// The <see cref="GetAccessControl"/> operation returns the
        /// access control data for a path.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/getproperties" />.
        /// </summary>
        /// <param name="userPrincipalName">
        /// Optional.Valid only when Hierarchical Namespace is enabled for the account.If "true",
        /// the user identity values returned in the x-ms-owner, x-ms-group, and x-ms-acl response
        /// headers will be transformed from Azure Active Directory Object IDs to User Principal Names.
        /// If "false", the values will be returned as Azure Active Directory Object IDs.The default
        /// value is false. Note that group and application Object IDs are not translated because they
        /// do not have unique friendly names.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on getting the path's access control.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathAccessControl}"/> describing the
        /// path's access control.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override Response<PathAccessControl> GetAccessControl(
#pragma warning restore AZC0003 // DO make service methods virtual.
            bool? userPrincipalName = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(GetAccessControl)}");

            try
            {
                scope.Start();

                return base.GetAccessControl(
                    userPrincipalName,
                    conditions,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="GetAccessControlAsync"/> operation returns the
        /// access control data for a path.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/getproperties" />.
        /// </summary>
        /// <param name="userPrincipalName">
        /// Optional.Valid only when Hierarchical Namespace is enabled for the account.If "true",
        /// the user identity values returned in the x-ms-owner, x-ms-group, and x-ms-acl response
        /// headers will be transformed from Azure Active Directory Object IDs to User Principal Names.
        /// If "false", the values will be returned as Azure Active Directory Object IDs.The default
        /// value is false. Note that group and application Object IDs are not translated because they
        /// do not have unique friendly names.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on getting the path's access control.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathAccessControl}"/> describing the
        /// path's access control.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override async Task<Response<PathAccessControl>> GetAccessControlAsync(
#pragma warning restore AZC0003 // DO make service methods virtual.
            bool? userPrincipalName = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(GetAccessControl)}");

            try
            {
                scope.Start();

                return await base.GetAccessControlAsync(
                    userPrincipalName,
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Get Access Control

        #region Set Access Control
        /// <summary>
        /// The <see cref="SetAccessControlList"/> operation sets the
        /// Access Control on a path
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/update" />.
        /// </summary>
        /// <param name="accessControlList">
        /// The POSIX access control list for the file or directory.
        /// </param>
        /// <param name="owner">
        /// The owner of the file or directory.
        /// </param>
        /// <param name="group">
        /// The owning group of the file or directory.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// setting the the path's access control.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathInfo}"/> describing the updated
        /// path.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override Response<PathInfo> SetAccessControlList(
#pragma warning restore AZC0003 // DO make service methods virtual.
            IList<PathAccessControlItem> accessControlList,
            string owner = default,
            string group = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(SetAccessControlList)}");

            try
            {
                scope.Start();

                return base.SetAccessControlList(
                    accessControlList,
                    owner,
                    group,
                    conditions,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="SetAccessControlListAsync"/> operation sets the
        /// Access Control on a path
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/update" />.
        /// </summary>
        /// <param name="accessControlList">
        /// The POSIX access control list for the file or directory.
        /// </param>
        /// <param name="owner">
        /// The owner of the file or directory.
        /// </param>
        /// <param name="group">
        /// The owning group of the file or directory.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// setting the the path's access control.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathInfo}"/> describing the updated
        /// path.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override async Task<Response<PathInfo>> SetAccessControlListAsync(
#pragma warning restore AZC0003 // DO make service methods virtual.
            IList<PathAccessControlItem> accessControlList,
            string owner = default,
            string group = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(SetAccessControlList)}");

            try
            {
                scope.Start();

                return await base.SetAccessControlListAsync(
                    accessControlList,
                    owner,
                    group,
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Set Access Control

        #region Set Permissions
        /// <summary>
        /// The <see cref="SetPermissions"/> operation sets the
        /// file permissions on a path.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/update" />.
        /// </summary>
        /// <param name="permissions">
        ///  The POSIX access permissions for the file owner, the file owning group, and others.
        /// </param>
        /// <param name="owner">
        /// The owner of the file or directory.
        /// </param>
        /// <param name="group">
        /// The owning group of the file or directory.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// setting the the path's access control.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathInfo}"/> describing the updated
        /// path.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override Response<PathInfo> SetPermissions(
#pragma warning restore AZC0003 // DO make service methods virtual.
            PathPermissions permissions,
            string owner = default,
            string group = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(SetPermissions)}");

            try
            {
                scope.Start();

                return base.SetPermissions(
                    permissions,
                    owner,
                    group,
                    conditions,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }

        }

        /// <summary>
        /// The <see cref="SetPermissionsAsync"/> operation sets the
        /// file permissions on a path.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/update" />.
        /// </summary>
        /// <param name="permissions">
        ///  The POSIX access permissions for the file owner, the file owning group, and others.
        /// </param>
        /// <param name="owner">
        /// The owner of the file or directory.
        /// </param>
        /// <param name="group">
        /// The owning group of the file or directory.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// setting the the path's access control.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathInfo}"/> describing the updated
        /// path.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override async Task<Response<PathInfo>> SetPermissionsAsync(
#pragma warning restore AZC0003 // DO make service methods virtual.
            PathPermissions permissions,
            string owner = default,
            string group = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(SetPermissions)}");

            try
            {
                scope.Start();

                return await base.SetPermissionsAsync(
                    permissions,
                    owner,
                    group,
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Set Permissions

        #region Get Properties
        /// <summary>
        /// The <see cref="GetProperties"/> operation returns all
        /// user-defined metadata, standard HTTP properties, and system
        /// properties for the path. It does not return the content of the
        /// path.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/get-blob-properties" />.
        /// </summary>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on getting the path's properties.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathProperties}"/> describing the
        /// path's properties.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public virtual Response<PathProperties> GetProperties(
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(GetProperties)}");

            try
            {
                scope.Start();

                return base.GetProperties(
                    conditions,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }


        /// <summary>
        /// The <see cref="GetPropertiesAsync"/> operation returns all
        /// user-defined metadata, standard HTTP properties, and system
        /// properties for the path. It does not return the content of the
        /// path.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/get-blob-properties" />.
        /// </summary>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on getting the path's properties.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathProperties}"/> describing the
        /// paths's properties.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override async Task<Response<PathProperties>> GetPropertiesAsync(
#pragma warning restore AZC0003 // DO make service methods virtual.
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(GetProperties)}");

            try
            {
                scope.Start();

                return await base.GetPropertiesAsync(
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Get Properties

        #region Set Http Headers
        /// <summary>
        /// The <see cref="SetHttpHeaders"/> operation sets system
        /// properties on the path.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/set-blob-properties" />.
        /// </summary>
        /// <param name="httpHeaders">
        /// Optional. The standard HTTP header system properties to set.  If not specified, existing values will be cleared.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// setting the paths's HTTP headers.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{httpHeaders}"/> describing the updated
        /// path.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override Response<PathInfo> SetHttpHeaders(
#pragma warning restore AZC0003 // DO make service methods virtual.
            PathHttpHeaders httpHeaders = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(SetHttpHeaders)}");

            try
            {
                scope.Start();

                return base.SetHttpHeaders(
                    httpHeaders,
                    conditions,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="SetHttpHeadersAsync"/> operation sets system
        /// properties on the PATH.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/set-blob-properties" />.
        /// </summary>
        /// <param name="httpHeaders">
        /// Optional. The standard HTTP header system properties to set.  If not specified, existing values will be cleared.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// setting the path's HTTP headers.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathInfo}"/> describing the updated
        /// path.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override async Task<Response<PathInfo>> SetHttpHeadersAsync(
#pragma warning restore AZC0003 // DO make service methods virtual.
            PathHttpHeaders httpHeaders = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(SetHttpHeaders)}");

            try
            {
                scope.Start();

                return await base.SetHttpHeadersAsync(
                        httpHeaders,
                        conditions,
                        cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Set Http Headers

        #region Set Metadata
        /// <summary>
        /// The <see cref="SetMetadata"/> operation sets user-defined
        /// metadata for the specified path as one or more name-value pairs.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/set-blob-metadata" />.
        /// </summary>
        /// <param name="metadata">
        /// Custom metadata to set for this path.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// setting the path's metadata.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathInfo}"/> describing the updated
        /// path.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override Response<PathInfo> SetMetadata(
#pragma warning restore AZC0003 // DO make service methods virtual.
            Metadata metadata,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(SetMetadata)}");

            try
            {
                scope.Start();

                return base.SetMetadata(
                    metadata,
                    conditions,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="SetMetadataAsync"/> operation sets user-defined
        /// metadata for the specified path as one or more name-value pairs.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/set-blob-metadata" />.
        /// </summary>
        /// <param name="metadata">
        /// Custom metadata to set for this path.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// setting the path's metadata.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{PathInfo}"/> describing the updated
        /// path.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
#pragma warning disable AZC0003 // DO make service methods virtual.
        public override async Task<Response<PathInfo>> SetMetadataAsync(
#pragma warning restore AZC0003 // DO make service methods virtual.
            Metadata metadata,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(SetMetadata)}");

            try
            {
                scope.Start();

                return await base.SetMetadataAsync(
                    metadata,
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Set Metadata

        #region Create File
        /// <summary>
        /// The <see cref="CreateFile"/> operation creates a file in this directory.
        ///
        /// For more information, see https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/create.
        /// </summary>
        /// <param name="fileName">
        /// The name of the file to create.
        /// </param>
        /// <param name="httpHeaders">
        /// Optional standard HTTP header properties that can be set for the
        /// new file or directory..
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata to set for this file or directory..
        /// </param>
        /// <param name="permissions">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account. Sets POSIX access
        /// permissions for the file owner, the file owning group, and others. Each class may be granted read,
        /// write, or execute permission. The sticky bit is also supported. Both symbolic (rwxrw-rw-) and 4-digit
        /// octal notation (e.g. 0766) are supported.
        /// </param>
        /// <param name="umask">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account.
        /// When creating a file or directory and the parent folder does not have a default ACL,
        /// the umask restricts the permissions of the file or directory to be created. The resulting
        /// permission is given by p bitwise-and ^u, where p is the permission and u is the umask. For example,
        /// if p is 0777 and u is 0057, then the resulting permission is 0720. The default permission is
        /// 0777 for a directory and 0666 for a file. The default umask is 0027. The umask must be specified
        /// in 4-digit octal notation (e.g. 0766).
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on the creation of this file or directory..
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{DataLakeFileClient}"/> for the
        /// newly created file.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response<DataLakeFileClient> CreateFile(
            string fileName,
            PathHttpHeaders httpHeaders = default,
            Metadata metadata = default,
            string permissions = default,
            string umask = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(CreateFile)}");

            try
            {
                scope.Start();

                DataLakeFileClient fileClient = GetFileClient(fileName);

                Response<PathInfo> response = fileClient.Create(
                    httpHeaders,
                    metadata,
                    permissions,
                    umask,
                    conditions,
                    cancellationToken);

                return Response.FromValue(
                    fileClient,
                    response.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="CreateFileAsync"/> operation creates a new file in this directory.
        ///
        /// For more information, see https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/create.
        /// </summary>
        /// <param name="fileName">
        /// Name of the file to create.
        /// </param>
        /// <param name="httpHeaders">
        /// Optional standard HTTP header properties that can be set for the
        /// new file or directory..
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata to set for this file or directory..
        /// </param>
        /// <param name="permissions">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account. Sets POSIX access
        /// permissions for the file owner, the file owning group, and others. Each class may be granted read,
        /// write, or execute permission. The sticky bit is also supported. Both symbolic (rwxrw-rw-) and 4-digit
        /// octal notation (e.g. 0766) are supported.
        /// </param>
        /// <param name="umask">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account.
        /// When creating a file or directory and the parent folder does not have a default ACL,
        /// the umask restricts the permissions of the file or directory to be created. The resulting
        /// permission is given by p bitwise-and ^u, where p is the permission and u is the umask. For example,
        /// if p is 0777 and u is 0057, then the resulting permission is 0720. The default permission is
        /// 0777 for a directory and 0666 for a file. The default umask is 0027. The umask must be specified
        /// in 4-digit octal notation (e.g. 0766).
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on the creation of this file or directory..
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{DataLakeFileClient}"/> for the
        /// newly created file.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response<DataLakeFileClient>> CreateFileAsync(
            string fileName,
            PathHttpHeaders httpHeaders = default,
            Metadata metadata = default,
            string permissions = default,
            string umask = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(CreateFile)}");

            try
            {
                scope.Start();

                DataLakeFileClient fileClient = GetFileClient(fileName);

                Response<PathInfo> response = await fileClient.CreateAsync(
                    httpHeaders,
                    metadata,
                    permissions,
                    umask,
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);

                return Response.FromValue(
                    fileClient,
                    response.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Create File

        #region Delete File
        /// <summary>
        /// The <see cref="DeleteFile"/> operation deletes a file
        /// in this directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/delete" />.
        /// </summary>
        /// <param name="fileName">
        /// The name of the file to delete.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// deleting this path.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> on successfully deleting.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response DeleteFile(
            string fileName,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(DeleteFile)}");

            try
            {
                scope.Start();

                return GetFileClient(fileName).Delete(
                    conditions,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="DeleteFileAsync"/> operation deletes a file
        /// in this directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/delete" />.
        /// </summary>
        /// <param name="fileName">
        /// The name of the file to delete.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// deleting this path.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> on successfully deleting.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response> DeleteFileAsync(
            string fileName,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(DeleteFile)}");

            try
            {
                scope.Start();

                return await GetFileClient(fileName).DeleteAsync(
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Delete File

        #region Create Sub Directory
        /// <summary>
        /// The <see cref="CreateSubDirectory"/> operation creates a sub directory in this directory.
        ///
        /// For more information, see https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/create.
        /// </summary>
        /// <param name="path">
        /// The path to the directory to create.
        /// </param>
        /// <param name="httpHeaders">
        /// Optional standard HTTP header properties that can be set for the
        /// new file or directory..
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata to set for this file or directory..
        /// </param>
        /// <param name="permissions">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account. Sets POSIX access
        /// permissions for the file owner, the file owning group, and others. Each class may be granted read,
        /// write, or execute permission. The sticky bit is also supported. Both symbolic (rwxrw-rw-) and 4-digit
        /// octal notation (e.g. 0766) are supported.
        /// </param>
        /// <param name="umask">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account.
        /// When creating a file or directory and the parent folder does not have a default ACL,
        /// the umask restricts the permissions of the file or directory to be created. The resulting
        /// permission is given by p bitwise-and ^u, where p is the permission and u is the umask. For example,
        /// if p is 0777 and u is 0057, then the resulting permission is 0720. The default permission is
        /// 0777 for a directory and 0666 for a file. The default umask is 0027. The umask must be specified
        /// in 4-digit octal notation (e.g. 0766).
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on the creation of this file or directory..
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{DataLakeDirectoryClient}"/> for the
        /// newly created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response<DataLakeDirectoryClient> CreateSubDirectory(
            string path,
            PathHttpHeaders httpHeaders = default,
            Metadata metadata = default,
            string permissions = default,
            string umask = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(CreateSubDirectory)}");

            try
            {
                scope.Start();

                DataLakeDirectoryClient directoryClient = GetSubDirectoryClient(path);

                Response<PathInfo> response = directoryClient.Create(
                    PathResourceType.Directory,
                    httpHeaders,
                    metadata,
                    permissions,
                    umask,
                    conditions,
                    cancellationToken);

                return Response.FromValue(
                    directoryClient,
                    response.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="CreateSubDirectoryAsync"/> operation creates a sub directory in this directory.
        ///
        /// For more information, see https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/create.
        /// </summary>
        /// <param name="path">
        /// The path to the directory to create.
        /// </param>
        /// <param name="httpHeaders">
        /// Optional standard HTTP header properties that can be set for the
        /// new file or directory..
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata to set for this file or directory..
        /// </param>
        /// <param name="permissions">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account. Sets POSIX access
        /// permissions for the file owner, the file owning group, and others. Each class may be granted read,
        /// write, or execute permission. The sticky bit is also supported. Both symbolic (rwxrw-rw-) and 4-digit
        /// octal notation (e.g. 0766) are supported.
        /// </param>
        /// <param name="umask">
        /// Optional and only valid if Hierarchical Namespace is enabled for the account.
        /// When creating a file or directory and the parent folder does not have a default ACL,
        /// the umask restricts the permissions of the file or directory to be created. The resulting
        /// permission is given by p bitwise-and ^u, where p is the permission and u is the umask. For example,
        /// if p is 0777 and u is 0057, then the resulting permission is 0720. The default permission is
        /// 0777 for a directory and 0666 for a file. The default umask is 0027. The umask must be specified
        /// in 4-digit octal notation (e.g. 0766).
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add
        /// conditions on the creation of this file or directory..
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{DataLakeDirectoryClient}"/> for the
        /// newly created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response<DataLakeDirectoryClient>> CreateSubDirectoryAsync(
            string path,
            PathHttpHeaders httpHeaders = default,
            Metadata metadata = default,
            string permissions = default,
            string umask = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(CreateSubDirectory)}");

            try
            {
                scope.Start();

                DataLakeDirectoryClient directoryClient = GetSubDirectoryClient(path);

                Response<PathInfo> response = await directoryClient.CreateAsync(
                    PathResourceType.Directory,
                    httpHeaders,
                    metadata,
                    permissions,
                    umask,
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);

                return Response.FromValue(
                    directoryClient,
                    response.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Create Sub Directory

        #region Delete Sub Directory
        /// <summary>
        /// The <see cref="DeleteSubDirectory"/> deletes a sub directory in this directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/delete" />.
        /// </summary>
        /// <param name="path">
        /// The path to the directory to delete.
        /// </param>
        /// <param name="continuation">
        /// Optional. When deleting a directory, the number of paths that are deleted with each invocation is limited.
        /// If the number of paths to be deleted exceeds this limit, a continuation token is returned in this response header.
        /// When a continuation token is returned in the response, it must be specified in a subsequent invocation of the delete
        /// operation to continue deleting the directory.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// deleting this path.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> on successfully deleting.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response DeleteSubDirectory(
            string path,
            string continuation = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(DeleteSubDirectory)}");

            try
            {
                scope.Start();

                return GetSubDirectoryClient(path).Delete(
                    recursive: true,
                    conditions,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// The <see cref="DeleteSubDirectoryAsync"/> deletes a sub directory in this directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/datalakestoragegen2/path/delete" />.
        /// </summary>
        /// <param name="path">
        /// The path to the directory to delete.
        /// </param>
        /// <param name="continuation">
        /// Optional. When deleting a directory, the number of paths that are deleted with each invocation is limited.
        /// If the number of paths to be deleted exceeds this limit, a continuation token is returned in this response header.
        /// When a continuation token is returned in the response, it must be specified in a subsequent invocation of the delete
        /// operation to continue deleting the directory.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on
        /// deleting this path.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> on successfully deleting.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response> DeleteSubDirectoryAsync(
            string path,
            string continuation = default,
            DataLakeRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            DiagnosticScope scope = ClientDiagnostics.CreateScope($"{nameof(DataLakeDirectoryClient)}.{nameof(DeleteSubDirectory)}");

            try
            {
                scope.Start();

                return await GetSubDirectoryClient(path).DeleteAsync(
                    recursive: true,
                    conditions,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }
        #endregion Delete Sub Directory
    }
}